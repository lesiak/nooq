namespace Nooq
{
    public interface SelectDistinctOnStep<R> : SelectIntoStep<R> where R : Record
    {
    }
}