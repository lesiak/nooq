namespace Nooq
{
    public interface SelectConnectByStep<R> : SelectGroupByStep<R> where R : Record
    {
    }
}