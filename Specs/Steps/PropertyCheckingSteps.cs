using NUnit.Framework;
using Should.Fluent;
using Specs.Util;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Specs.Steps
{
    [Binding]
    public class PropertyCheckingSteps
    {
        [Then(@"the (.*) property should be of type (.*) and equal (.*)")]
        public void ThenThePropertyShouldBeOfTypeAndEqual(string propertyName, string propertyTypeName, string propertyValue)
        {
            var propertyType = ReflectionUtil.GetTypeByName(propertyTypeName);
            var instanceDict = State.OriginalInstance as IDictionary<string, object>;

            instanceDict[propertyName].Should().Be.OfType(propertyType);

            Convert.ChangeType(propertyValue, propertyType).Should().Equal(instanceDict[propertyName]);
        }

        [Then(@"the (\d+) item should have property (.*) of type (.*) equal to (.*)")]
        public void ItemInSetShouldHavePropertyOfTypeEqualTo(int itemNumber, string propertyName, string propertyTypeName, string propertyValue)
        {
            var item = GetItem(itemNumber) as IDictionary<string, object>;
            var propertyType = ReflectionUtil.GetTypeByName(propertyTypeName);
            var typedPropertyValue = Convert.ChangeType(propertyValue, propertyType);

            Assert.AreEqual(typedPropertyValue, item[propertyName]);
        }

        private static dynamic GetItem(int itemNumber)
        {
            return State.OriginalSet[itemNumber - 1];
        }

    }
}
