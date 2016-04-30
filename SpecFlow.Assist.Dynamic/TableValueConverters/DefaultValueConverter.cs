using System;

namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Default table value converter which tries to convert the value
    /// to base types (<see cref="int"/>, <see cref="double"/>, <see cref="decimal"/>, <see cref="bool"/>, <see cref="DateTime"/> respecively)
    /// and returns the value as string if the conversion fails.
    /// </summary>
    public class DefaultValueConverter : ITableValueConverter
    {
        public object Convert(string value)
        {
            int i;
            if (int.TryParse(value, out i))
                return i;

            double db;
            if (Double.TryParse(value, out db))
            {
                decimal d;
                if (Decimal.TryParse(value, out d) && d.Equals((decimal)db))
                {
                    return db;
                }
                return d;
            }

            bool b;
            if (Boolean.TryParse(value, out b))
                return b;

            DateTime dt;
            if (DateTime.TryParse(value, out dt))
                return dt;

            return value;
        }
    }
}
