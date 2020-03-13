namespace Nooq
{
    public interface Record
    {
        /// <summary>
        /// Get a specific field from this Record.
        /// @see Row#field(Name)
        /// </summary>
        /// <see cref="Row.field(string)"/>
        Field field(string name);
        
        /// <summary>
        /// Get a specific qualified field from this Record.
        /// @see Row#field(Name)
        /// </summary>
        Field field(Name name);
    }
}