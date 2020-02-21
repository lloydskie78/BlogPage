using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_Project_MVC.Controllers
{
   

    public class BlogController : Controller
    {
        BlogEntities nd = new BlogEntities();

        // GET: Blog
        public ActionResult Index()
        {
            var blogdetails = nd.Blogs.ToList().OrderByDescending(x=>x.Bid);
            return View(blogdetails);
        }

        public ActionResult UploadBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadBlog(Blog bg)
        {
           
            nd.Blogs.Add(bg);
            nd.SaveChanges();

            ViewBag.message = "Blog Details are saved successfully!";
            return View();
        }

        public ActionResult Food()
        {
            var foodarticle = nd.Blogs.Where(x => x.BCategory == "Food");
            return View(foodarticle);
        }

        public ActionResult Sports()
        {
            var sportsarticle = nd.Blogs.Where(x => x.BCategory == "Sports");
            return View(sportsarticle);
        }

        public ActionResult Movies()
        {
            var moviesarticle = nd.Blogs.Where(x => x.BCategory == "Movies");
            return View(moviesarticle);
        }

        public ActionResult Recipesworld()
        {
            return View();
        }
    }
}