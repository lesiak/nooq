namespace Nooq
{
    public interface SelectHavingStep<R> : SelectWindowStep<R> where R : Record
    {
    }
}