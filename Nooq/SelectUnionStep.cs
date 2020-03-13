namespace Nooq
{
    public interface SelectUnionStep<R> : SelectFinalStep<R> where R : Record
    {
    }
}