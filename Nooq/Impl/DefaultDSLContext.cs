namespace Nooq.Impl
{
    public class DefaultDSLContext : AbstractScope, DSLContext
    {
        public SelectWhereStep<R> selectFrom<R>(Table<R> table) where R : class, Record
        {
            return new SelectImpl<R>(configuration(), null).from(table);
        }

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
            // return selectFrom(table).where(condition).fetchLazy();
            throw new System.NotImplementedException();
        }
    }
}