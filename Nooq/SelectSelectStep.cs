namespace Nooq
{
    public interface SelectSelectStep<R> : SelectDistinctOnStep<R> where R : Record
    {
    }
}