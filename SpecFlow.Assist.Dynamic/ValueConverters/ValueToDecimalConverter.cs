using System;

namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Tries to convert the value to decimal, otherwise returns null.
    /// </summary>
    public class ValueToDecimalConverter : ITableValueConverter
    {
        public object Convert(string tableValue)
        {
            decimal value;
            if (Decimal.TryParse(tableValue, out value))
            {
                return value;
            }

            return null;
        }
    }
}
