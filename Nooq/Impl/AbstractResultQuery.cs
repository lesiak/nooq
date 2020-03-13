namespace Nooq.Impl
{
    public class AbstractResultQuery<R> : AbstractQuery, ResultQuery<R> where R : Record
    {
        private int maxRows;
        private int fetchSize;
        private bool lazy;
        private Cursor<R> cursor;

        public Cursor<R> fetchLazy()
        {
            return fetchLazy(fetchSize);
        }

        public Cursor<R> fetchLazy(int size)
        {
            int previousFetchSize = fetchSize;

            // [#3515] TODO: Avoid modifying a Query's per-execution state
            lazy = true;
            fetchSize = size;

            try
            {
                execute();
            }
            finally
            {
                lazy = false;
                fetchSize = previousFetchSize;
            }

            return cursor;
        }
    }
}