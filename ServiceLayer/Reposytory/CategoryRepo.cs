using System;
using System.Collections.Generic;
using System.Linq;
using DomainLayer.Model;
using DomainLayer.Reposytory;

namespace ServiceLayer.Reposytory
{
    public class CategoryRepo : BaseRepo<Category>, ICategoryReposytory<Category>
    {
        public CategoryRepo()
        {
            Table = Context.Categories;
        }
        // Закоментировал,т.к. планирую передавать весь (небольшой справочник "Категорий")
        //public List<string> GetCategoryList()
        //{
        //    List<string> listCategory = new List<string>();
        //    List<Category> allCategoryRecords = GetAll() as List<Category>;

        //    var querry = from category in allCategoryRecords
        //                 select new { category.Name };

        //    foreach (var item in querry)
        //    {
        //        listCategory.Add(item.Name);
        //    }
        //    return listCategory;
        //}

        public int GetIdbyName(string name)
        {
            var result = from category in Table
                         where category.Name == name
                         select category.Id;
            return result.ToList()[0];
        }
    }
}
