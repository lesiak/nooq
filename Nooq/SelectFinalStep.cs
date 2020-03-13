namespace Nooq
{
    public interface SelectFinalStep<R> : Select<R> where R : Record
    {
    }
}