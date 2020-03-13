using System;

namespace Nooq
{
    public interface Cursor<R>: IDisposable where R: Record
    {
        Result<R> fetchNext(int number);
    }
}