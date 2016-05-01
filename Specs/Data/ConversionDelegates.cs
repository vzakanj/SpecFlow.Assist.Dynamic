using System;
using System.Globalization;

namespace Specs.Data
{
    public static class ConversionDelegates
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
