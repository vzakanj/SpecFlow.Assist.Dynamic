using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace Specs.Util
{
    public static class ConversionDelegateUtil
    {
        public static Func<string, object> GetConversionDelegateByName(string delegateName)
        {
            var funcField = typeof(ConversionDelegateUtil).GetField(delegateName, BindingFlags.Static | BindingFlags.Public);
            var func = (Func<string, object>)funcField.GetValue(null);
            return func;
        }

        public static Func<string, object>[] GetConversionDelegatesByNames(string commaSeparatedNames)
        {
            var delegateNames = StringUtil.GetNames(commaSeparatedNames);
            var delegates = new List<Func<string, object>>();

            foreach (var name in delegateNames)
            {
                delegates.Add(GetConversionDelegateByName(name));
            }

            return delegates.ToArray();
        }

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
