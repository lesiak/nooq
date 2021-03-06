namespace Nooq
{
    public interface ResultQuery<R> : Query where R : Record
    {
        Cursor<R> fetchLazy();
    }
}