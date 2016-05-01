using System;
using System.Collections.Generic;
using Should.Fluent;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using Specs.Util;
using System.Reflection;
using System.Linq;
using System.Globalization;
using Specs.Data;

namespace Specs.Steps
{
    [Binding]
    public class DynamicInstanceCreationSteps
    {

        [Given(@"I create a dynamic instance from this table")]
        [When(@"I create a dynamic instance from this table")]
        public void CreateDynamicInstanceFromTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance();
        }


        [When(@"I create a dynamic instance with only reserved chars")]
        public void OnlyReservedChars(Table table)
        {
            try
            {
                State.OriginalInstance = table.CreateDynamicInstance();                 
            }
            catch (DynamicInstanceFromTableException ex)
            {
                ScenarioContext.Current.Set(ex);
            }
        }

        [Then(@"an exception with a nice error message about the property only containing reserved chars should be thrown")]
        public void ThenAnExceptionWithANiceErrorMessageAboutThePropertyOnlyContainingReservedCharsShouldBeThrown()
        {
            var ex = ScenarioContext.Current.Get<DynamicInstanceFromTableException>();
            ex.Should().Not.Be.Null();
            ex.Message.Should().Contain("only contains");
        }

        [When(@"I create a dynamic instance with only ValueToDateTime converter using date format (.*) from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeConverterUsingDateFormatFromThisTable(string dateFormat, Table table)
        {
            var converter = new ValueToDateTimeConverter(dateFormat);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }



    }
}
