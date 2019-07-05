using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    [Route("blog")] //global level, not to repeat in every action method
    public class BlogController : Controller
    {
        // GET: /<controller>/
        [Route("")] // to use the route defined from the configuration
        public IActionResult Index(int page = 0)
        {
            int pageSize = 2;
            int totalPosts = _db.Posts.Count();
            var op = Convert.ToDecimal(totalPosts) / pageSize;
            int totalPages = (int)Math.Floor(op);
            int prevPage = page - 1;
            int nextpage = page + 1;

            ViewBag.PreviousPage = prevPage;
            ViewBag.NextPage = nextpage;
            ViewBag.HasPreviousPage = prevPage >= 0;
            ViewBag.HasNextPage = nextpage < totalPages;

            var posts = _db.Posts
                        .OrderByDescending(x => x.Posted)
                        .Skip(pageSize * page)
                        .Take(pageSize)
                        .ToArray();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(posts);

            return View(posts);
        }

        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext db)
        {
            _db = db;
        }

        //[Route("")] // to use the route defined from the configuration
        //public IActionResult Index()
        //{
        //    return new ContentResult { Content = "Blog post" };
        //}

        //[Route("{year:min(2000)}/{month:range(1,12)}/{key}")]  
        //public IActionResult Post(int year, int month, string key)
        //{
        //    return new ContentResult { Content = $"Year: {year}; Month: {month}; Key: {key}" };
        //}

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")] // custom attribute route with restrictions
        public IActionResult Post(int year, int month, string key)
        {
            //ViewBag.Title = "My blog post";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Author = "Jess Chadwick";
            //ViewBag.Body = $"This is a great blog post, Is that right? \n Year: {year}; Month: {month}; Key: {key}";

            //var post = new Post
            //{
            //    Title = "My blog post",
            //    Posted = DateTime.Now,
            //    Author = "Jess Chadwick",
            //    Body = $"This is a great blog post, Is that right? \n Year: {year}; Month: {month}; Key: {key}"
            //};

            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            return View(post);
        }

        [Authorize]
        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost, Route("Create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
                return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            //saving to db
            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }
    }
}
