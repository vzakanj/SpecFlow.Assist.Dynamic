namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// All values are returned as their <see cref="string"/> representations
    /// in the table.
    /// </summary>
    public class ValueToStringConverter : ITableValueConverter
    {
        public object Convert(string value)
        {
            return value;
        }
    }
}
