namespace SpecFlow.Assist.Dynamic
{
    /// <summary>
    /// Interface for converters of table values.
    /// </summary>
    public interface ITableValueConverter
    {
        object Convert(string tableValue);
    }
}