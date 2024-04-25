using Microsoft.AspNetCore.Mvc;
using WebUI.Data;
using WebUI.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class TagController : Controller
    {
        private readonly AppDbContext _context;

        public TagController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()

        {
            var tags=_context.Tags.ToList();
            return View(tags);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Tag tag ) 
        {
            if (tag.TagName==null)
            {
                ModelState.AddModelError("error", "Tag name is required");
                return View();
            }
            var chechkTag=_context.Tags.FirstOrDefault(x=> x.TagName==tag.TagName);
            if (chechkTag!=null)
            {
                //ModelState.AddModelError("error", "Tag name is already exist");
                ViewBag.Error = "Tag name is already exist";
                return View(chechkTag);

            }
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
            return Redirect("/admin/tag/index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var findTag = _context.Tags.FirstOrDefault(x=>x.Id==id);
            if (findTag==null) 
            {
                return NotFound();
            }
                return View(findTag);
        }
        [HttpPost]
        public IActionResult Edit(Tag tag)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(tag);
            //}
            //var checkTag = _context.Tags.FirstOrDefault(x => x.Id == tag.Id);
            //if (checkTag != null)
            //{
            //    ViewBag.Error = "Tag name is already exist!";
            //}
            if (tag.TagName == null)
            {

                ViewBag.Error = "TagName is required!";
                return View();
            }//silende niye islemir???????


            _context.Tags.Update(tag);
            _context.SaveChanges();
            return Redirect("/admin/tag/index");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null) return NotFound();
            var tag = _context.Tags.FirstOrDefault(y=>y.Id==id);
            if (tag == null) return NotFound();
            return View(tag);
        }
        [HttpPost]
        public  IActionResult Delete(Tag tag)
        {
             _context.Tags.Remove(tag);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
