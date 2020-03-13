namespace Nooq.Impl
{
    public class CursorImpl<R>: Cursor<R> where R: Record
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Result<R> fetchNext(int number)
        {
            throw new System.NotImplementedException();
        }
    }
}