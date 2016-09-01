using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nop.Data;
using Nop.Core.Domain.Blogs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace Nop.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LazyloadingTest()
        {
            NopObjectContext context = new NopObjectContext();

            context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            var blogs = context.Set<BlogPost>();
            
            var repository = new EfRepository<BlogPost>(context);
            
            BlogPost blog = repository.GetById(11);
            var comments = blog.BlogComments;
            Assert.IsNotNull(blog);
        }


        [TestMethod]
        public void EagerloadingTest()
        {
            NopObjectContext context = new NopObjectContext();
            context.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
            var blogs = context.Set<BlogPost>();

            //var blog = blogs.Include("BlogComments").FirstOrDefault(x => x.Id == 11);
            var blog = blogs.Include(x => x.BlogComments).FirstOrDefault(x => x.Id == 11);
            Assert.IsNotNull(blog);
        }
    }
}
