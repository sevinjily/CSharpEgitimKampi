using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCategoryDAL : EFRepositoryBase<Category, AppDbContext>, ICategoryDAL
    {
        public void CreateCategory(List<AddCategoryDTO> models)
        {
            using var context = new AppDbContext();
            Category category = new Category(); 
            context.Categories.Add(category);
            context.SaveChanges();
            for (int i = 0; i < models.Count; i++)
            {
                CategoryLanguage categoryLanguage = new()
                {
                    CategoryName = models[i].Name,
                    LangCode = models[i].LangCode,
                    CategoryId = category.Id
                };
            }
        }
    }
}
