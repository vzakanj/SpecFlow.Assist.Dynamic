using SpecFlow.Assist.Dynamic;
using Specs.Data;
using Specs.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Specs.Steps
{
    [Binding]
    public class SharedScenarioSteps
    {
        [When(@"I create a set of dynamic instances using only (.*) converter from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingOnlyConverterFromThisTable(string converterName, Table table)
        {
            State.OriginalSet = table.CreateDynamicSet(GetTableValueConverterByName(converterName)).ToList();
        }

        [When(@"I create a set of dynamic instances using only ValueToDateTime converter with date format dd/MM/yyyy from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingOnlyValueToDateTimeConverterWithDateFormatDdMMYyyyFromThisTable(Table table)
        {
            var converter = new ValueToDateTimeConverter("dd/MM/yyyy");

            State.OriginalSet = table.CreateDynamicSet(converter).ToList();
        }

        [When(@"I create a dynamic instance with only (.*) converter from this table")]
        public void WhenICreateADynamicInstanceWithOnlyConverterFromThisTable(string converterName, Table table)
        {
            var converter = GetTableValueConverterByName(converterName);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }

        [When(@"I create a dynamic instance with converters (.*) from this table")]
        public void WhenICreateADynamicInstanceWithConvertersFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converterNames = GetNameArray(commaSeparatedConverterNames);

            var converters = new List<ITableValueConverter>();
            foreach (var name in converterNames)
            {
                converters.Add(GetTableValueConverterByName(name));
            }

            State.OriginalInstance = table.CreateDynamicInstance(converters.ToArray());
        }

        [When(@"I create a set of dynamic instances using converters (.*) from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingConvertersFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converterNames = GetNameArray(commaSeparatedConverterNames);

            var converters = new List<ITableValueConverter>();
            foreach (var name in converterNames)
            {
                converters.Add(GetTableValueConverterByName(name));
            }

            State.OriginalSet = table.CreateDynamicSet(converters.ToArray()).ToList();
        }

        [When(@"I create a set of dynamic instances using only (.*) delegate from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingOnlyDelegateFromThisTable(string funcName, Table table)
        {
            Func<string, object> func = GetConversionDelegateByName(funcName);
            State.OriginalSet = table.CreateDynamicSet(func).ToList();
        }

        [When(@"I create a set of dynamic instances using only ValueToDateTime delegate with date format dd/MM/yyyy from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingOnlyValueToDateTimeDelegateWithDateFormatDdMMYyyyFromThisTable(Table table)
        {
            State.OriginalSet = table.CreateDynamicSet(ConversionDelegates.ValueToDateTime_ddMMyyyy).ToList();
        }

        [When(@"I create a set of dynamic instances using delegates (.*) from this table")]
        public void WhenICreateASetOfDynamicInstancesUsingDelegatesValueToDecimalValueToStringFromThisTable(string commaSeparatedFuncNames, Table table)
        {
            var funcNames = GetNameArray(commaSeparatedFuncNames);

            var convertFuncs = new List<Func<string, object>>();

            foreach (var name in funcNames)
            {
                convertFuncs.Add(GetConversionDelegateByName(name));
            }

            State.OriginalSet = table.CreateDynamicSet(convertFuncs.ToArray()).ToList();
        }


        [When(@"I create a dynamic instance with only (.*) delegate from this table")]
        public void WhenICreateADynamicInstanceWithOnlyDelegateFromThisTable(string funcName, Table table)
        {
            Func<string, object> func = GetConversionDelegateByName(funcName);

            State.OriginalInstance = table.CreateDynamicInstance(func);
        }

        [When(@"I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeDelegateUsingDateFormatDdMMYyyyFromThisTable(Table table)
        {
            State.OriginalInstance = table.CreateDynamicInstance(ConversionDelegates.ValueToDateTime_ddMMyyyy);
        }


        [When(@"I create a dynamic instance with delegates (.*) from this table")]
        public void WhenICreateADynamicInstanceWithDelegatesFromThisTable(string commaSeparatedFuncNames, Table table)
        {
            var funcNames = GetNameArray(commaSeparatedFuncNames);

            var convertFuncs = new List<Func<string, object>>();

            foreach (var name in funcNames)
            {
                convertFuncs.Add(GetConversionDelegateByName(name));
            }

            State.OriginalInstance = table.CreateDynamicInstance(convertFuncs.ToArray());
        }

        private string[] GetNameArray(string commaSeparatedNames)
        {
            return commaSeparatedNames
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.Trim())
                .ToArray();
        }

        private static Func<string, object> GetConversionDelegateByName(string funcName)
        {
            var funcField = typeof(ConversionDelegates).GetField(funcName, BindingFlags.Static | BindingFlags.Public);
            var func = (Func<string, object>)funcField.GetValue(null);
            return func;
        }

        private ITableValueConverter GetTableValueConverterByName(string converterName)
        {
            var converterTypeName = converterName + "Converter";
            var dynamicValueConverterType = ReflectionUtil.GetTypeByName(converterTypeName);

            return (ITableValueConverter)Activator.CreateInstance(dynamicValueConverterType);
        }
    }
}
