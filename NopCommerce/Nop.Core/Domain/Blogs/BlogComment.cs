using System;

namespace Nop.Core.Domain.Blogs
{
    public partial class BlogComment : BaseEntity
    {
        /// <summary>
        /// Gets or sets the comment text
        /// </summary>
        public string CommentText { get; set; }

        /// <summary>
        /// Gets or sets the blog post identifier
        /// </summary>
        public int BlogPostId { get; set; }

        /// <summary>
        /// Gets or sets the date and time of instance creation
        /// </summary>
        public DateTime CreatedOnUtc { get; set; }

        public BlogPost BlogPost { get; set; }
    }
}
