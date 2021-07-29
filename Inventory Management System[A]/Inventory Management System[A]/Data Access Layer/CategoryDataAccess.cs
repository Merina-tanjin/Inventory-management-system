using Inventory_Management_System_A_.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Data_Access_Layer
{
    class CategoryDataAccess
    {
        DataAccess dataAccess;
        public CategoryDataAccess()
        {
            this.dataAccess = new DataAccess();
        }

        public List<Category> GetAllCategories()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader= this.dataAccess.GetData(sql);
            List<Category> categories = new List<Category>();
            while (reader.Read())
            {
                Category category = new Category();
                category.CategoryId = (int)reader["CategoryId"];
                category.CategoryName = reader["CategoryName"].ToString();
                categories.Add(category);
            }
            return categories;
        }

        public Category GetCategory(int id)
        {
            string sql = "SELECT * FROM Categories WHERE CategoryId="+id;
            SqlDataReader reader = this.dataAccess.GetData(sql);
            reader.Read();
            Category category = new Category();
            category.CategoryId = (int)reader["CategoryId"];
            category.CategoryName = reader["CategoryName"].ToString();  
            return category;
        }


        public int InsertCategory(Category category)
        {
            string sql = "INSERT INTO Categories(CategoryName) VALUES('"+category.CategoryName+"')";
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public int UpdateCategory(Category category)
        {
            string sql = "UPDATE Categories SET CategoryName='"+category.CategoryName+"' WHERE CategoryId="+category.CategoryId;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }
        public int DeleteCategory(int id)
        {
            string sql = "DELETE FROM Categories WHERE CategoryId="+id;
            int result = this.dataAccess.ExecuteQuery(sql);
            return result;
        }

        public List<string> GetAllCategoryNames()
        {
            string sql = "SELECT * FROM Categories";
            SqlDataReader reader = this.dataAccess.GetData(sql);
            List<string> categories = new List<string>();
            while (reader.Read())
            {
                categories.Add(reader["CategoryName"].ToString());
            }
            return categories;
        }

        public List<Product> GetProductListByCategory(string categoryName)
        {
            string categoryIdSearchSql = "SELECT * FROM Categories WHERE CategoryName='"+categoryName+"'";
            SqlDataReader reader = this.dataAccess.GetData(categoryIdSearchSql);
            reader.Read();
            int categoryId = (int)reader["CategoryId"];
            string sql = "SELECT * FROM Products WHERE CategoryId=" + categoryId;
            dataAccess = new DataAccess();
            reader = dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity= (int)reader["Quantity"];
                product.CategoryId= (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
    }
}
