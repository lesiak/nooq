namespace Nooq
{
    public interface SelectIntoStep<R> : SelectFromStep<R> where R : Record
    {
        
    }
}