namespace Nooq.Impl
{
    public abstract class AbstractQuery : Query
    {
        public int execute()
        {
            throw new System.NotImplementedException();
        }

        public virtual bool isExecutable()
        {
            return true;
        }
    }
}