namespace Nooq
{
    public interface Field
    {
        
    }

    public interface Field<T>: Field, SelectField<T>
    {
    }
}