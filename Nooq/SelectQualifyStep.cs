namespace Nooq
{
    public interface SelectQualifyStep<R> : SelectOrderByStep<R> where R : Record
    {
    }
}