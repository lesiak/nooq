namespace Nooq
{
    public interface Table<R> : TableLike<R> where R : Record
    {
    }
}