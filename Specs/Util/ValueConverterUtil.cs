using SpecFlow.Assist.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Specs.Util
{
    public static class ValueConverterUtil
    {
        public static ITableValueConverter GetValueConverterByName(string converterName)
        {
            var converterTypeName = converterName + "Converter";
            var dynamicValueConverterType = ReflectionUtil.GetTypeByName(converterTypeName);

            return (ITableValueConverter)Activator.CreateInstance(dynamicValueConverterType);
        }

        public static ITableValueConverter[] GetValueConvertersByNames(string commaSeparatedConverterNames)
        {
            var converterNames = StringUtil.GetNames(commaSeparatedConverterNames);

            var converters = new List<ITableValueConverter>();
            foreach (var name in converterNames)
            {
                converters.Add(GetValueConverterByName(name));
            }

            return converters.ToArray();
        }
    }
}
