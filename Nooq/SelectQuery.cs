namespace Nooq
{
    public interface SelectQuery<R> : Select<R> where R : Record
    {
        void addFrom<X>(TableLike<X> from) where X : Record;
    }
}