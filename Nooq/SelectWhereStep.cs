namespace Nooq
{
    public interface SelectWhereStep<R> : SelectConnectByStep<R> where R : Record
    {
    }
}