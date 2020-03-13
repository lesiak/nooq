namespace Nooq
{
    public interface SelectForUpdateStep<R> : SelectOptionStep<R> where R : Record
    {
    }
}