﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using WebUI.Data;
using WebUI.Helpers;
using WebUI.Models;
using System.IO;

namespace WebUI.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
   
    public class ArticleController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly UserManager<User> _userManager;
        public ArticleController(AppDbContext context, IWebHostEnvironment env, IHttpContextAccessor contextAccessor, UserManager<User> userManager)
        {
            _context = context;
            _env = env;
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var articles=_context.Articles.
                Where(x=>x.IsDeleted==false).
                Include(x=>x.Category).
                Include(x=>x.ArticleTag). 
                ThenInclude(x=>x.Tag).
                ToList();
            return View(articles);
        }
        [Authorize]

        [HttpGet]
        public IActionResult Create()
        {
            var categories=_context.Categories.ToList();
            var tags=_context.Tags.ToList();
            ViewData["tags"] = tags;
            ViewBag.Categories = new SelectList(categories,"Id","CategoryName");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Article article,IFormFile file,List<int> tagIds) 

        {
            var categories = _context.Categories.ToList();
            var tags = _context.Tags.ToList();
            ViewData["tags"] = tags;
            ViewBag.Categories = new SelectList(categories, "Id", "CategoryName");


            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            Article newArticle = new Article();
            if (file != null) 
            {

                newArticle.PhotoUrl = await file.SaveFileAsync(_env.WebRootPath,"/article-images/");
           
           
               
            }
            else {
                return View();
            }
            
           
           
            newArticle.Title = article.Title;
            newArticle.Content = article.Content;
            newArticle.CreatedDate= DateTime.Now;
            newArticle.CategoryId = article.CategoryId;
            newArticle.IsActive = article.IsActive;
            newArticle.isFeatured=article.isFeatured;
            newArticle.CreatedBy = user.FirstName+" "+user.LastName;
            newArticle.SeoUrl = article.Title.ReplaceInvalidChars();

           await _context.Articles.AddAsync(newArticle);
            await _context.SaveChangesAsync();
            for(int i = 0; i < tagIds.Count; i++)
			{

                ArticleTag articleTag = new()
                {
                    ArticleId = newArticle.Id,
                    TagId = tagIds[i],
                };
                await _context.ArticleTags.AddAsync(articleTag);
            }
            await _context.SaveChangesAsync();

            return Redirect("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
           var article= _context.Articles.FirstOrDefault(x => x.Id == id);
            var path = (Path.Combine( _env.WebRootPath + article.PhotoUrl.Replace('/','\\')));

            if (System.IO.File.Exists(path))
            {

            System.IO.File.Delete(path);
            }
            //Birbasa sekilleri serverden silmek ucun yazilir SYstem.IO
            _context.Articles.Remove(article);
           await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null) return NotFound();



            var article=await _context.Articles.Include(x=>x.ArticleTag).
               FirstOrDefaultAsync(x=>x.Id==id);
            if(article == null)
            {
                return NotFound();
            }
            var categories = _context.Categories.ToList();
            var tags = _context.Tags.ToList();
            ViewBag.Tags = tags;
            ViewBag.Categories = new SelectList(categories, "Id", "CategoryName");
            return View(article);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Article article,IFormFile file,List<int> tagIds)
        {
            var categories=_context.Categories.ToList();
            var tags=_context.Tags.ToList();
            ViewBag.Tags = tags;
            ViewBag.Categories = new SelectList(categories, "Id", "CategoryName");

            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user=await _userManager.FindByIdAsync(userId);

            if (file != null)
            {
                article.PhotoUrl = await file.SaveFileAsync(_env.WebRootPath, "/article-images/");
            }
            article.SeoUrl = article.Title.ReplaceInvalidChars();
            article.UpdateDate = DateTime.Now;
            article.UpdatedBy=user.FirstName+" "+user.LastName;

            var findTags = _context.ArticleTags.Where(x=>x.ArticleId==article.Id).ToList();
            _context.ArticleTags.RemoveRange(findTags);
        

            for (int i = 0; i < tagIds.Count; i++)
            {

                ArticleTag articleTag = new()
                {
                    ArticleId = article.Id,
                    TagId = tagIds[i],
                };
                await _context.ArticleTags.AddAsync(articleTag);
            }
            await _context.SaveChangesAsync();

            _context.Articles.Update(article);
           await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
