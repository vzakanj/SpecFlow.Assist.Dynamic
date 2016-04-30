using System;

namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Tries to convert the value to <see cref="double"/>, otherwise returns null.
    /// </summary>
    public class ValueToDoubleConverter : ITableValueConverter
    {
        public object Convert(string tableValue)
        {
            double value;
            if (Double.TryParse(tableValue, out value))
            {
                return value;
            }

            return null;
        }
    }
}
