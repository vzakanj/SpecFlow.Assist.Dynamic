using System;
using System.Globalization;

namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Tries to convert the value to <see cref="DateTime"/>, otherwise returns null.
    /// </summary>
    public class ValueToDateTimeConverter : ITableValueConverter
    {
        private readonly string[] formats;

        public ValueToDateTimeConverter() { }

        public ValueToDateTimeConverter(params string[] formats)
        {
            this.formats = formats;
        }
        
        public object Convert(string tableValue)
        {
            DateTime date;
            if (DateTime.TryParseExact(tableValue, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                return date;
            }

            return null;
        }
    }
}
