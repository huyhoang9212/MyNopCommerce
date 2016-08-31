using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nop.Services.Blogs;
using Nop.Core.Domain.Blogs;

namespace Nop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBlogService _blogService;
        public HomeController(IBlogService blogService)
        {
            _blogService = blogService;
        } 

        public ActionResult Index()
        {
            BlogPost blogPost = _blogService.GetBlogPostById(11);
            ViewBag.NumberOfBlog = _blogService.GetAllBlogs().Count();
            return View(blogPost);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}