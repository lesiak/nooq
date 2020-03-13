namespace Nooq
{
    public interface SelectGroupByStep<R> : SelectHavingStep<R> where R : Record
    {
    }
}