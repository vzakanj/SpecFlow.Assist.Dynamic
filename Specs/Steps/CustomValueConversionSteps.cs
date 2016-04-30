using System;
using SpecFlow.Assist;
using SpecFlow.Assist.Dynamic;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using Should.Fluent;

namespace Specs.Steps
{
    [Binding]
    public class CustomValueConversionSteps
    {
        private Dictionary<string, Type> typeCache = new Dictionary<string, Type>();

        [When(@"I create a dynamic instance with only (.*) converter from this table")]
        public void WhenICreateADynamicInstanceWithCustomConverterFromThisTable(string converterName, Table table)
        {
            var converter = GetTableValueConverterByName(converterName);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }

        [Then(@"the (.*) property should be of type (.*) and equal (.*)")]
        public void ThenThePropertyShouldBeOfTypeAndEqual(string propertyName, string propertyTypeName, string propertyValue)
        {
            var propertyType = GetTypeByName(propertyTypeName);
            var instanceDict = State.OriginalInstance as IDictionary<string, object>;
            instanceDict[propertyName].Should().Be.OfType(propertyType);

            Convert.ChangeType(propertyValue, propertyType).Should().Equal(instanceDict[propertyName]);
        }

        [When(@"I create a dynamic instance with converters (.*) from this table")]
        public void WhenICreateADynamicInstanceWithConvertersValueToDecimalValueToStringFromThisTable(string commaSeparatedConverterNames, Table table)
        {
            var converterNames = GetNameArray(commaSeparatedConverterNames);

            var converters = new List<ITableValueConverter>();
            foreach (var name in converterNames)
            {
                converters.Add(GetTableValueConverterByName(name));
            }

            State.OriginalInstance = table.CreateDynamicInstance(converters.ToArray());
        }

        [When(@"I create a dynamic instance with only (.*) delegate from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToStringDelegateFromThisTable(string funcName, Table table)
        {
            Func<string, object> func = GetConverterFuncByName(funcName);

            State.OriginalInstance = table.CreateDynamicInstance(func);
        }

        [When(@"I create a dynamic instance with delegates (.*) from this table")]
        public void WhenICreateADynamicInstanceWithDelegatesValueToDecimalValueToStringFromThisTable(string commaSeparatedFuncNames, Table table)
        {
            var funcNames = GetNameArray(commaSeparatedFuncNames);

            var convertFuncs = new List<Func<string, object>>();

            foreach (var name in funcNames)
            {
                convertFuncs.Add(GetConverterFuncByName(name));
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

        private static Func<string, object> GetConverterFuncByName(string funcName)
        {
            var funcField = typeof(ConverterFuncs).GetField(funcName, BindingFlags.Static | BindingFlags.Public);
            var func = (Func<string, object>)funcField.GetValue(null);
            return func;
        }

        private ITableValueConverter GetTableValueConverterByName(string converterName)
        {
            var converterTypeName = converterName + "Converter";
            var dynamicValueConverterType = GetTypeByName(converterTypeName);

            return (ITableValueConverter)Activator.CreateInstance(dynamicValueConverterType);
        }

        private Type GetTypeByName(string typeName)
        {
            if (typeCache.ContainsKey(typeName))
            {
                return typeCache[typeName];
            }

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                var type = assembly.GetTypes().FirstOrDefault(t => t.Name == typeName);
                if (type != null)
                {
                    typeCache.Add(typeName, type);
                    return type;
                }
            }

            throw new ArgumentException("Type " + typeName + " couldn't be found.", "propertyTypeName");
        }
    }

    public static class ConverterFuncs
    {
        public static Func<string, object> ValueToString = value => value;

        public static Func<string, object> ValueToDecimal = value =>
        {
            decimal decVal;
            if (Decimal.TryParse(value, out decVal))
            {
                return decVal;
            }

            return null;
        };

        public static Func<string, object> ValueToDouble = value =>
        {
            double doubleVal;
            if (Double.TryParse(value, out doubleVal))
            {
                return doubleVal;
            }

            return null;
        };

        public static Func<string, object> ValueToInt = value =>
        {
            int intVal;
            if (Int32.TryParse(value, out intVal))
            {
                return intVal;
            }

            return null;
        };
    }
}
