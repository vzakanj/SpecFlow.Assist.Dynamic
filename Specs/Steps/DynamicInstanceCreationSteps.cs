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

        [When(@"I create a dynamic instance with only (.*) converter from this table")]
        public void WhenICreateADynamicInstanceWithCustomConverterFromThisTable(string converterName, Table table)
        {
            var converter = GetTableValueConverterByName(converterName);
            State.OriginalInstance = table.CreateDynamicInstance(converter);
        }

        [When(@"I create a dynamic instance with only ValueToDateTime converter using date format (.*) from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeConverterUsingDateFormatFromThisTable(string dateFormat, Table table)
        {
            var converter = new ValueToDateTimeConverter(dateFormat);
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

        [When(@"I create a dynamic instance with only (.*) delegate from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToStringDelegateFromThisTable(string funcName, Table table)
        {
            Func<string, object> func = GetConversionDelegateByName(funcName);

            State.OriginalInstance = table.CreateDynamicInstance(func);
        }

        [When(@"I create a dynamic instance with only ValueToDateTime delegate using date format dd/MM/yyyy from this table")]
        public void WhenICreateADynamicInstanceWithOnlyValueToDateTimeDelegateUsingDateFormatDdMMYyyyFromThisTable(Table table)
        {
            Func<string, object> func = GetConversionDelegateByName("ValueToDateTime_ddMMyyyy");

            State.OriginalInstance = table.CreateDynamicInstance(func);
        }


        [When(@"I create a dynamic instance with delegates (.*) from this table")]
        public void WhenICreateADynamicInstanceWithDelegatesValueToDecimalValueToStringFromThisTable(string commaSeparatedFuncNames, Table table)
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
            var funcField = typeof(ConverterDelegates).GetField(funcName, BindingFlags.Static | BindingFlags.Public);
            var func = (Func<string, object>)funcField.GetValue(null);
            return func;
        }

        private ITableValueConverter GetTableValueConverterByName(string converterName)
        {
            var converterTypeName = converterName + "Converter";
            var dynamicValueConverterType = ReflectionUtil.GetTypeByName(converterTypeName);

            return (ITableValueConverter)Activator.CreateInstance(dynamicValueConverterType);
        }

        public static class ConverterDelegates
        {
            public static Func<string, object> ValueToString = value => value;

            public static Func<string, object> ValueToDateTime = value =>
            {
                DateTime date;

                if (DateTime.TryParse(value, out date))
                {
                    return date;
                }

                return null;
            };

            public static Func<string, object> ValueToDateTime_ddMMyyyy = value =>
            {
                DateTime date;

                if (DateTime.TryParseExact(value, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out date))
                {
                    return date;
                }

                return null;
            };

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
}
