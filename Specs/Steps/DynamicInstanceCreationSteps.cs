using System;
using Should.Fluent;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using Specs.Util;

namespace Specs.Steps
{
    [Binding]
    public class DynamicInstanceCreationSteps : TechTalk.SpecFlow.Steps
    {

        [Given(@"I create a dynamic instance from this table")]
        [When(@"I create a dynamic instance from this table")]
        public void CreateDynamicInstanceFromTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance();
        }

        [When(@"I create a dynamic instance using (.*) delegate from table (.*)")]
        public void WhenICreateADynamicInstanceUsingDelegateFromTable(string delegateName, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a dynamic instance using {0} delegate from this table", delegateName), table);
        }

        [When(@"I create a dynamic instance using (.*) delegate from this table")]
        public void WhenICreateADynamicInstanceUsingDelegateFromThisTable(string delegateName, Table table)
        {
            Func<string, object> func = ConversionDelegateUtil.GetConversionDelegateByName(delegateName);
            State.OriginalInstance = table.CreateDynamicInstance(func);
        }

        [When(@"I create a dynamic instance using delegates (.*) from table (.*)")]
        public void WhenICreateADynamicInstanceUsingDelegatesFromThisTable(string commaSeparatedDelegateNames, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a dynamic instance using delegates {0} from this table", commaSeparatedDelegateNames), table);
        }

        [When(@"I create a dynamic instance using delegates (.*) from this table")]
        public void WhenICreateADynamicInstanceUsingDelegatesFromThisTable(string commaSeparatedDelegateNames, Table table)
        {
            var conversionDelegates = ConversionDelegateUtil.GetConversionDelegatesByNames(commaSeparatedDelegateNames);
            State.OriginalInstance = table.CreateDynamicInstance(conversionDelegates);
        }

        [When(@"I create a dynamic instance using (.*) converter from table (.*)")]
        public void WhenICreateADynamicInstanceUsingConverterFromThisTable(string converterName, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a dynamic instance using {0} converter from this table", converterName), table);
        }

        [When(@"I create a dynamic instance using (.*) converter from this table")]
        public void WhenICreateADynamicInstanceUsingConverterFromThisTable(string converterName, Table table)
        {
            var converter = ValueConverterUtil.GetValueConverterByName(converterName);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }

        [When(@"I create a dynamic instance using converters (.*) from table (.*)")]
        public void WhenICreateADynamicInstanceUsingConvertersFromThisTable(string commaSeparatedConverterNames, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a dynamic instance using converters {0} from this table", commaSeparatedConverterNames), table);
        }

        [When(@"I create a dynamic instance using converters (.*) from this table")]
        public void WhenICreateADynamicInstanceUsingConvertersFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converters = ValueConverterUtil.GetValueConvertersByNames(commaSeparatedConverterNames);
            State.OriginalInstance = table.CreateDynamicInstance(converters);
        }

        [When(@"I create a dynamic instance using ValueToDateTime delegate using date format dd/MM/yyyy from this table")]
        public void WhenICreateADynamicInstanceUsingValueToDateTimeDelegateUsingDateFormatDdMMYyyyFromThisTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance(ConversionDelegateUtil.ValueToDateTime_ddMMyyyy);
        }

        [When(@"I create a dynamic instance using ValueToDateTime delegate using date format dd/MM/yyyy from table (.*)")]
        public void WhenICreateADynamicInstanceUsingValueToDateTimeDelegateUsingDateFormatDdMMYyyyFromTable(string tableName)
        {
            var table = State.GetTable(tableName);
            When("I create a dynamic instance using ValueToDateTime delegate with date format dd/MM/yyyy from this table", table);
        }

        [When(@"I create a dynamic instance using ValueToDateTime converter with date format (.*) from this table")]
        public void WhenICreateADynamicInstanceWithValueToDateTimeConverterUsingDateFormatFromThisTable(string dateFormat, Table table)
        {
            var converter = new ValueToDateTimeConverter(dateFormat);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
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
    }
}
