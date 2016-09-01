using System;
using System.Data.Entity;
using Nop.Core;
using Nop.Data.Mapping.Blogs;

namespace Nop.Data
{
    public class NopObjectContext : DbContext, IDbContext
    {
        public NopObjectContext()
            :base("name=MyNopConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NopObjectContext,
                Migrations.Configuration>("MyNopConnectionString"));
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BlogPostMap());
            modelBuilder.Configurations.Add(new BlogCommentMap());
            base.OnModelCreating(modelBuilder);
        }
        

        #region Methods
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }
        #endregion
    }
}
