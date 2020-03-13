namespace Nooq
{
    public interface SelectOrderByStep<R> : SelectLimitStep<R> where R : Record
    {
    }
}