using System;
using System.Collections.Generic;

namespace DomainModels.Categories
{
    public class SubCategoryModel
    {
        public SubCategoryModel()
        {
            CategoriesId = new List<CategoryModel>();
        }

        public Guid Id { get; set; }
        public String SubCategoryName { get; set; }
        public virtual ICollection<CategoryModel> CategoriesId { get; set; } 
    }
}
