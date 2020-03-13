using System.Collections.Generic;

namespace Nooq
{
    public interface Result<R>: IList<R> where R: Record
    {
        
    }
}