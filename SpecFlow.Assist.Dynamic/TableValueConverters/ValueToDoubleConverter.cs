using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecFlow.Assist.Dynamic.TableValueConverters
{
    /// <summary>
    /// Tries to convert the value to <see cref="double"/>, otherwise returns null.
    /// </summary>
    public class ValueToDecimalConverter : ITableValueConverter
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
