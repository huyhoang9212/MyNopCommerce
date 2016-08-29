using Nop.Core.Domain.Blogs;

namespace Nop.Services.Blogs
{
    public interface IBlogService
    {
        BlogPost GetBlogPostById(int blogPostId);

        void DeleteBlogPost(BlogPost blogPost);

        void InsertBlogPost(BlogPost blogPost);

        void UpdateBlogPost(BlogPost blogPost);
    }
}
