namespace Nooq
{
    public interface Query
    {
        int execute();

        /// <summary>
        /// Whether this query is executable in its current state.
        /// DML queries may be incomplete in structure and thus not executable.
        /// Calling {@link #execute()} on such queries has no effect, but beware that
        /// @link #getSQL()} may not render valid SQL!
        /// </summary>
        /// 
        /// <returns></returns>
        bool isExecutable();
    }
}