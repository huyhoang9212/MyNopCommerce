using System;
using Nop.Core.Domain.Blogs;

namespace Nop.Data.Mapping.Blogs
{
    public partial class BlogPostMap : NopEntityTypeConfiguration<BlogPost>
    {
        public BlogPostMap()
        {
            // Primary Key
            this.HasKey(pr => pr.Id);

            // Properties
            this.Property(bp => bp.Title).IsRequired();
            this.Property(bp => bp.Body).IsRequired();
            this.Property(bp => bp.MetaKeywords).HasMaxLength(400);
            this.Property(bp => bp.MetaTitle).HasMaxLength(400);

            // Table & Column mapping
            this.ToTable("BlogPost");
        }
    }
}
