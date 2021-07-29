using Inventory_Management_System_A_.Data_Access_Layer;
using Inventory_Management_System_A_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Business_Logic_Layer
{
    class CategoryService
    {
        CategoryDataAccess categoryDataAccess;
        public CategoryService()
        {
            this.categoryDataAccess = new CategoryDataAccess();
        }

        public List<Category> GetCategoryList()
        {
            return this.categoryDataAccess.GetAllCategories();
        }

        public int AddNewCategory(string categoryName)
        {
            Category category = new Category() { CategoryName = categoryName };
            return this.categoryDataAccess.InsertCategory(category);
        }
        public int UpdateCategory(int id,string categoryName)
        {
            Category category = new Category() { CategoryId=id,CategoryName = categoryName };
            return this.categoryDataAccess.UpdateCategory(category);
        }
        public int DeleteCategory(int id)
        {
            return this.categoryDataAccess.DeleteCategory(id);
        }

        public List<string> GetCategoryNameList()
        {
            return this.categoryDataAccess.GetAllCategoryNames();
        }

        public List<Product> GetProductListByCategory(string categoryName)
        {
            return this.categoryDataAccess.GetProductListByCategory(categoryName);
        }
    }
}
