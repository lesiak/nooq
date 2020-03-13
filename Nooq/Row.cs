namespace Nooq
{
    public interface Row
    {
        /// <summary>
        /// Get a specific field from this row.
        /// </summary>
        /// <param name="fieldName">The field to fetch</param>
        /// <returns>The field with the given name</returns>
        Field field(string fieldName);
    }
}