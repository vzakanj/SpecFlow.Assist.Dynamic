using System;
using System.Linq;
using NUnit.Framework;
using Should.Fluent;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using Specs.Util;

namespace Specs.Steps
{
    [Binding]
    public class DynamicSetCreationSteps
    {
        private static dynamic GetItem(int itemNumber)
        {
            return State.OriginalSet[itemNumber - 1];
        }
        

        [Given(@"I create a set of dynamic instances from this table")]
        [When(@"I create a set of dynamic instances from this table")]
        public void WithMethodBinding(Table table)
        {
            State.OriginalSet = table.CreateDynamicSet().ToList();   
        }
        

        [Then(@"I should have a list of (\d+) dynamic objects")]
        public void ShouldContain(int expectedNumberOfItems)
        {
            State.OriginalSet.Count.Should().Equal(expectedNumberOfItems);
        }

        [Then(@"the (\d+) item should have property (.*) of type (.*) equal to (.*)")]
        public void ItemInSetShouldHavePropertyOfTypeEqualTo(int itemNumber, string propertyName, string propertyTypeName, string propertyValue)
        {
            var item = GetItem(itemNumber) as IDictionary<string, object>;
            var propertyType = ReflectionUtil.GetTypeByName(propertyTypeName);
            var typedPropertyValue = Convert.ChangeType(propertyValue, propertyType);

            Assert.AreEqual(typedPropertyValue, item[propertyName]);
        }
    }
}
