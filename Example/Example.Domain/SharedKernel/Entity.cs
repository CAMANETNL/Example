namespace Example.Domain.SharedKernel
{
    public abstract class Entity
    {
        // Don't use GUIDs
        // https://www.sqlskills.com/blogs/kimberly/guids-as-primary-keys-andor-the-clustering-key/
        // https://stackoverflow.com/a/11938495

        public int Id { get; private set; }
    }
}