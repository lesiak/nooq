namespace Nooq
{
    public interface Select<R> : ResultQuery<R>, TableLike<R> where R : Record
    {
    }
}