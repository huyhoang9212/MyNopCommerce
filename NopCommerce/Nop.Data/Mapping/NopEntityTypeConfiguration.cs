using System.Data.Entity.ModelConfiguration;


namespace Nop.Data.Mapping
{
    public abstract class NopEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected NopEntityTypeConfiguration()
        {
            PostInitalize();
        }

        protected virtual void PostInitalize()
        {

        }
    }
}
