namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Tries to convert the value to <see cref="int"/>, otherwise returns null.
    /// </summary>
    public class ValueToIntConverter : ITableValueConverter
    {
        public object Convert(string tableValue)
        {
            int value;
            if (int.TryParse(tableValue, out value))
            {
                return value;
            }

            return null;
        }
    }
}
