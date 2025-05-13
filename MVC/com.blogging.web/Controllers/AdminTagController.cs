using com.blogging.web.Models.Domain;
using com.blogging.web.Models.ViewModel;
using com.bloging.web.Data;
using Microsoft.AspNetCore.Mvc;

namespace com.blogging.web.Controllers
{

    public class AdminTagsController : Controller
    {
        private BloggieDbContext _bloggieDbContext;

        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            _bloggieDbContext = bloggieDbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)//Add in Database 
        {
            //var Name = Request.Form["Name"];
            //var Display = Request.Form["DisplayName"];
            Tag tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            _bloggieDbContext.Add(tag);
            _bloggieDbContext.SaveChanges();
            return View("Add");
        }
        [HttpGet]
        public IActionResult List()// Showing  a list
        {
            var tags = _bloggieDbContext.Tags.ToList();


            return View(tags);

        }
        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            //var tags = _bloggieDbContext.Tags.Find(id);
            var tag = _bloggieDbContext.Tags.FirstOrDefault(x=>x.Id==id);
            if(tag!=null)
            {
                EditTagRequest editTagRequest = new EditTagRequest
                {
                    Id = tag.Id,
                    Name = tag.Name,
                    DisplayName = tag.DisplayName

                };
                return View(editTagRequest);

            }

            return View(null);
        }
        [HttpPost]
        public IActionResult Edit(EditTagRequest editTagRequest)//for update
        {
            var tag = new Tag
            {
                Id=editTagRequest.Id,
                Name=editTagRequest.Name,
                DisplayName=editTagRequest.DisplayName

            };
            var ExistingTag = _bloggieDbContext.Tags.Find(tag.Id);
            if(ExistingTag!=null)
            {
                ExistingTag.Name = tag.Name;
                ExistingTag.DisplayName = tag.DisplayName;
                _bloggieDbContext.SaveChanges();
                return RedirectToAction("List", new {id=editTagRequest.Id});

            }
            return RedirectToAction("Edit", new { id = editTagRequest.Id });
        }
        public IActionResult Delete(EditTagRequest editTagRequest)
        { 
            var ExistingTag = _bloggieDbContext.Tags.Find(editTagRequest.Id);
            if(ExistingTag!=null)
            {
                _bloggieDbContext.Tags.Remove(ExistingTag);
                _bloggieDbContext.SaveChanges();
                return RedirectToAction("List");
            }
            return RedirectToAction("List");
        }

    }
}