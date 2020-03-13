namespace Nooq
{
    public interface SelectLimitStep<R> : SelectForUpdateStep<R> where R : Record
    {
    }
}