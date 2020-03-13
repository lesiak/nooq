namespace Nooq.Impl
{
    public class AbstractDelegatingQuery<Q> where Q : Query
    {
        private readonly Q queryDelegate;

        public AbstractDelegatingQuery(Q queryDelegate)
        {
            this.queryDelegate = queryDelegate;
        }
        
        public Q getQueryDelegate() {
            return queryDelegate;
        }
    }
}