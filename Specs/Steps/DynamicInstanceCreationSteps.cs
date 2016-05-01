using System;
using Should.Fluent;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using Specs.Util;

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

        [When(@"I create a dynamic instance with only (.*) delegate from this table")]
        public void WhenICreateADynamicInstanceWithOnlyDelegateFromThisTable(string delegateName, Table table)
        {
            Func<string, object> func = ConversionDelegateUtil.GetConversionDelegateByName(delegateName);
            State.OriginalInstance = table.CreateDynamicInstance(func);
        }

        [When(@"I create a dynamic instance with delegates (.*) from this table")]
        public void WhenICreateADynamicInstanceWithDelegatesFromThisTable(string commaSeparatedDelegateNames, Table table)
        {
            var conversionDelegates = ConversionDelegateUtil.GetConversionDelegatesByNames(commaSeparatedDelegateNames);
            State.OriginalInstance = table.CreateDynamicInstance(conversionDelegates);
        }

        [When(@"I create a dynamic instance with only (.*) converter from this table")]
        public void WhenICreateADynamicInstanceWithOnlyConverterFromThisTable(string converterName, Table table)
        {
            var converter = ValueConverterUtil.GetValueConverterByName(converterName);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }

        [When(@"I create a dynamic instance with converters (.*) from this table")]
        public void WhenICreateADynamicInstanceWithConvertersFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converters = ValueConverterUtil.GetValueConvertersByNames(commaSeparatedConverterNames);
            State.OriginalInstance = table.CreateDynamicInstance(converters);
        }

        [When(@"I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeDelegateUsingDateFormatDdMMYyyyFromThisTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance(ConversionDelegateUtil.ValueToDateTime_ddMMyyyy);
        }

        [When(@"I create a dynamic instance with only ValueToDateTime converter using date format (.*) from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeConverterUsingDateFormatFromThisTable(string dateFormat, Table table)
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
