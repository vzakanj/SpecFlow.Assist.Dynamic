using System;
using System.Linq;
using NUnit.Framework;
using Should.Fluent;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Collections.Generic;
using Specs.Util;
using SpecFlow.Assist.Dynamic;

namespace Specs.Steps
{
    [Binding]
    public class DynamicSetCreationSteps : TechTalk.SpecFlow.Steps
    {
        [When(@"I create a set of dynamic instances using only (.*) converter from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingOnlyConverterFromThisTable(string converterName, Table table)
        {
            State.OriginalSet = table.CreateDynamicSet(ValueConverterUtil.GetValueConverterByName(converterName)).ToList();
        }

        [When(@"I create a set of dynamic instances using ValueToDateTime converter with date format dd/MM/yyyy from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingValueToDateTimeConverterWithDateFormatDdMMYyyyFromThisTable(Table table)
        {
            var converter = new ValueToDateTimeConverter("dd/MM/yyyy");
            State.OriginalSet = table.CreateDynamicSet(converter).ToList();
        }

        [When(@"I create a set of dynamic instances using converters (.*) from table (.*)")]
        public void WhenICreateASetOfDynamicInstancesUsingConvertersFromTable(string commaSeparatedConverterNames, string tableName)
        {
            var table = State.GetTable(tableName);
            var converters = ValueConverterUtil.GetValueConvertersByNames(commaSeparatedConverterNames);
            State.OriginalSet = table.CreateDynamicSet(converters).ToList();
        }


        [When(@"I create a set of dynamic instances using converters (.*) from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingConvertersFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converters = ValueConverterUtil.GetValueConvertersByNames(commaSeparatedConverterNames);
            State.OriginalSet = table.CreateDynamicSet(converters).ToList();
        }

        [When(@"I create a set of dynamic instances using (.*) delegate from table (.*)")]
        public void WhenICreateASetOfDynamicInstancesUsingDelegateFrom(string delegateName, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a set of dynamic instances using {0} delegate from this table", delegateName), table);
        }

        [When(@"I create a set of dynamic instances using (.*) delegate from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingDelegateFromThisTable(string delegateName, Table table)
        {
            Func<string, object> func = ConversionDelegateUtil.GetConversionDelegateByName(delegateName);
            State.OriginalSet = table.CreateDynamicSet(func).ToList();
        }

        [When(@"I create a set of dynamic instances using ValueToDateTime delegate with date format dd/MM/yyyy from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingValueToDateTimeDelegateWithDateFormatDdMMYyyyFromThisTable(Table table)
        {
            State.OriginalSet = table.CreateDynamicSet(ConversionDelegateUtil.ValueToDateTime_ddMMyyyy).ToList();
        }

        [When(@"I create a set of dynamic instances using delegates (.*) from table (.*)")]
        public void WhenICreateASetOfDynamicInstancesUsingDelegatesFromThisTable(string commaSeparatedDelegateNames, string tableName)
        {
            var table = State.GetTable(tableName);
            When(String.Format("I create a set of dynamic instances using delegates {0} from this table", commaSeparatedDelegateNames), table);
        }

        [When(@"I create a set of dynamic instances using delegates (.*) from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingDelegatesFromThisTable(string commaSeparatedDelegateNames, Table table)
        {
            var conversionDelegates = ConversionDelegateUtil.GetConversionDelegatesByNames(commaSeparatedDelegateNames);
            State.OriginalSet = table.CreateDynamicSet(conversionDelegates).ToList();
        }
        

        [Given(@"I create a set of dynamic instances from this table")]
        [When(@"I create a set of dynamic instances from this table")]
        public void WhenICreateASetOfDynamicInstancesFromThisTable(Table table)
        {
            State.OriginalSet = table.CreateDynamicSet().ToList();   
        }

        [Then(@"I should have a list of (\d+) dynamic objects")]
        public void ShouldContain(int expectedNumberOfItems)
        {
            State.OriginalSet.Count.Should().Equal(expectedNumberOfItems);
        }

        [When(@"I create a set of dynamic instances using (.*) converter from table (.*)")]
        public void WhenICreateASetOfDynamicInstancesUsingConverterFromTable(string converterName, string tableName)
        {
            var table = State.GetTable(tableName);
            var converter = ValueConverterUtil.GetValueConverterByName(converterName);
            State.OriginalSet = table.CreateDynamicSet(converter).ToList();
        }
    }
}
