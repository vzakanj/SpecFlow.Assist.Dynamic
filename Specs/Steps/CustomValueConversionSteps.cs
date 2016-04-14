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
        public void WhenICreateADynamicInstanceWithConvertersValueToDecimalValueToStringFromThisTable(string converterNames, Table table)
        {
            var converterNameArr = converterNames
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => n.Trim())
                .ToArray();

            var converters = new List<ITableValueConverter>();
            foreach (var name in converterNameArr)
            {
                converters.Add(GetTableValueConverterByName(name));
            }

            State.OriginalInstance = table.CreateDynamicInstance(converters.ToArray());
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
}
