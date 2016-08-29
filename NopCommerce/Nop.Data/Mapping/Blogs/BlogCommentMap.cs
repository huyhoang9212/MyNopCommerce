using Nop.Core.Domain.Blogs;

namespace Nop.Data.Mapping.Blogs
{
    public partial class BlogCommentMap : NopEntityTypeConfiguration<BlogComment>
    {
        public BlogCommentMap()
        {
            // Primary Key
            this.HasKey(pr => pr.Id);

            // Properties
            this.Property(c => c.CommentText)
                .IsRequired();

            // Table and Column Mappings
            this.ToTable("BlogComment");

            // Relationships
            this.HasRequired(bc => bc.BlogPost)
                .WithMany(bp => bp.BlogComments)
                .HasForeignKey(bc => bc.BlogPostId)
                .WillCascadeOnDelete(true);
        }

    }
}
