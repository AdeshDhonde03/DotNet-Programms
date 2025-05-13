using com.blogging.web.Models.Domain;
using com.blogging.web.Models.ViewModel;
using com.bloging.web.Data;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;

namespace com.blogging.web.Controllers
{
    public class AdminBlogController : Controller
    {
        private BloggieDbContext _bloggiedbcontext;
        public AdminBlogController(BloggieDbContext bloggieDbContext) 
        {
            _bloggiedbcontext = bloggieDbContext;
        
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddBlogRequest addBlogRequest)
        {
            BlogPost blog = new BlogPost
            {
                Heading = addBlogRequest.Heading,
                PageTitle=addBlogRequest.PageTitle,
                Content=addBlogRequest.Content,
                ShortDescripton=addBlogRequest.ShortDescripton,
                FeaturedImageUrl=addBlogRequest.FeaturedImageUrl,
                UrlHandle=addBlogRequest.UrlHandle,
                PublishedDate=addBlogRequest.PublishedDate,
                Author = addBlogRequest.Author,
                Visible = addBlogRequest.Visible
            };
            _bloggiedbcontext.Add(blog);
            int v = _bloggiedbcontext.SaveChanges();
            return View("Add");

        }
    }
}
