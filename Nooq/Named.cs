namespace Nooq
{
    public interface Named : QueryPart
    {
        /// <summary>
        /// The unqualified name of this object.
        /// </summary>
        string getName();

        /// <summary>
        /// The qualified name of this object.
        /// </summary>
        Name getQualifiedName();

        /// <summary>
        /// The unqualified name of this object.
        /// </summary>
        Name getUnqualifiedName();
        
        /// <summary>
        /// The comment on this object.
        /// </summary>
        string getComment();
    }
}