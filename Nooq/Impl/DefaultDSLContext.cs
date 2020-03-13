namespace Nooq.Impl
{
    public class DefaultDSLContext: DSLContext
    {
        public R fetchOne<R>(Table<R> table, Condition condition) where R : class, Record
        {
            return Tools.fetchOne(fetchLazy(table, condition));
        }

        public Cursor<R> fetchLazy<R>(Table<R> table) where R : class, Record
        {
            return fetchLazy(table, DSL.noCondition());
        }

        public Cursor<R> fetchLazy<R>(Table<R> table, Condition condition) where R : class, Record
        {
            throw new System.NotImplementedException();
        }
    }
}