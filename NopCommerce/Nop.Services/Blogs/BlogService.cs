using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nop.Core.Domain.Blogs;
using Nop.Core.Data;

namespace Nop.Services.Blogs
{
    public partial class BlogService : IBlogService
    {
        private readonly IRepository<BlogPost> _blogPostRepository;

        public BlogService(IRepository<BlogPost> blogPostRepo)
        {
            this._blogPostRepository = blogPostRepo;
        }

        public void DeleteBlogPost(BlogPost blogPost)
        {
            if (blogPost == null)
                throw new ArgumentNullException("blogPost");

            _blogPostRepository.Delete(blogPost);
        }

        public IQueryable<BlogPost> GetAllBlogs()
        {
            return _blogPostRepository.Table;
        }

        public BlogPost GetBlogPostById(int blogPostId)
        {
            if (blogPostId == 0)
                return null;

            return _blogPostRepository.GetById(blogPostId);
        }

        public void InsertBlogPost(BlogPost blogPost)
        {
            if (blogPost == null)
                throw new ArgumentNullException("blogPost");

            _blogPostRepository.Insert(blogPost);
        }

        public void UpdateBlogPost(BlogPost blogPost)
        {
            if (blogPost == null)
                throw new ArgumentNullException("blogPost");

            _blogPostRepository.Update(blogPost);
        }
    }
}
