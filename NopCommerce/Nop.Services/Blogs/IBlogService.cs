using Nop.Core.Domain.Blogs;
using System.Linq;

namespace Nop.Services.Blogs
{
    public interface IBlogService
    {
        BlogPost GetBlogPostById(int blogPostId);

        IQueryable<BlogPost> GetAllBlogs();

        void DeleteBlogPost(BlogPost blogPost);

        void InsertBlogPost(BlogPost blogPost);

        void UpdateBlogPost(BlogPost blogPost);
    }
}
