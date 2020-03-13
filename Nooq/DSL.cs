using Nooq.Impl;

namespace Nooq
{
    public class DSL
    {
        public static Condition noCondition() {
            return NoCondition.INSTANCE;
        }
    }
}