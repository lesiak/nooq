namespace Nooq.Impl
{
    public class SelectQueryImpl<R> : AbstractResultQuery<R>, SelectQuery<R> where R : Record
    {
        private readonly TableList from;

        public SelectQueryImpl(Configuration configuration, WithImpl with, bool distinct) :
            this(configuration, with, null, distinct)
        {
        }

        public SelectQueryImpl(Configuration configuration, WithImpl with, TableLike<R> from, bool distinct)
        {
            this.from = new TableList();
            //if (from != null)
            //    this.from.add(from.asTable());
        }

        public void addFrom<X>(TableLike<X> from) where X : Record
        {
            throw new System.NotImplementedException();
        }
    }
}