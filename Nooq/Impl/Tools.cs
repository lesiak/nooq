using System;
using Nooq.Exception;

namespace Nooq.Impl
{
    public class Tools
    {
        internal static R fetchOne<R>(Cursor<R> cursor) where R : class, Record
        {
            return fetchOne(cursor, false);
        }

        private static R fetchOne<R>(Cursor<R> cursor, bool hasLimit1) where R : class, Record
        {
            try
            {
                // [#7001] Fetching at most two rows rather than at most one row
                //         (and then checking of additional rows) improves debug logs
                // [#7430] Avoid fetching the second row (additional overhead) if
                //         there is a guarantee of at most one row
                Result<R> result = cursor.fetchNext(hasLimit1 ? 1 : 2);
                int size = result.Count;

                if (size == 0)
                    return null;
                else if (size == 1)
                    return result[0];
                else
                    throw exception((CursorImpl<R>) cursor,
                        new TooManyRowsException("Cursor returned more than one result"));
            }
            finally
            {
                cursor.Dispose();
            }
        }

        private static System.Exception exception<R>(CursorImpl<R> cursor, System.Exception e) where R : Record
        {
            // [#8877] Make sure these exceptions pass through ExecuteListeners as well
            //cursor.ctx.exception(e);
            //cursor.listener.exception(cursor.ctx);
            //return cursor.ctx.exception();
            throw e;
        }
    }
}