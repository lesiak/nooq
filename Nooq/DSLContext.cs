namespace Nooq
{
    public interface DSLContext
    {
        SelectWhereStep<R> selectFrom<R>(Table<R> table) where R : class, Record;
        
        R fetchOne<R>(Table<R> table, Condition condition) where R : class, Record;

        Cursor<R> fetchLazy<R>(Table<R> table) where R : class, Record;

        Cursor<R> fetchLazy<R>(Table<R> table, Condition condition) where R : class, Record;
    }
}