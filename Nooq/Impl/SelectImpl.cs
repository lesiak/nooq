namespace Nooq.Impl
{
    public class SelectImpl<R> : AbstractDelegatingQuery<Select<R>>,
        // Cascading interface implementations for Select behaviour
        SelectSelectStep<R>
        // ,
        // SelectOptionalOnStep<R>,
        // SelectOnConditionStep<R>,
        // SelectConditionStep<R>,
        // SelectConnectByConditionStep<R>,
        // SelectConnectByAfterStartWithConditionStep<R>,
        // SelectConnectByAfterStartWithStep<R>,
        // SelectHavingConditionStep<R>,
        // SelectQualifyConditionStep<R>
        
        where R : Record
    {
        internal SelectImpl(Configuration configuration, WithImpl with) : this(configuration, with, false)
        {
        }


        SelectImpl(Configuration configuration, WithImpl with, bool distinct) : this(
            new SelectQueryImpl<R>(configuration, with, distinct))
        {
        }

        SelectImpl(Select<R> query) : base(query)
        {
        }
        
        public SelectQuery<R> getQuery() {
            return (SelectQuery<R>) getQueryDelegate();
        }
        
        public SelectImpl<R> from<X>(TableLike<X> table) where X: Record {
            getQuery().addFrom(table);
            return this;
        }
    }
}