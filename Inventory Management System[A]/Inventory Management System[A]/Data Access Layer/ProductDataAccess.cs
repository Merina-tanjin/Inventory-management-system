using Inventory_Management_System_A_.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Data_Access_Layer
{
    class ProductDataAccess
    {
        DataAccess dataAccess;
        public ProductDataAccess()
        {
            this.dataAccess = new DataAccess();
        }
        public List<Product> GetAllProducts()
        {
            string sql = "SELECT * FROM Products";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }
        public Product GetProduct(int id)
        {
            string sql = "SELECT * FROM Products WHERE ProductId="+id;
            SqlDataReader reader = dataAccess.GetData(sql);
            reader.Read();
            Product product = new Product();
            product.ProductId = (int)reader["ProductId"];
            product.ProductName = reader["ProductName"].ToString();
            product.Price = Convert.ToDouble(reader["Price"]);
            product.Quantity = (int)reader["Quantity"];
            product.CategoryId = (int)reader["CategoryId"];
            return product;
        }

        public int AddNewProduct(Product product)
        {
            string sql = "INSERT INTO Products(ProductName,Price,Quantity,CategoryId) VALUES('"+product.ProductName+"',"+product.Price+","+product.Quantity+","+product.CategoryId+")";
            return this.dataAccess.ExecuteQuery(sql);
        }
        public int GetCategoryId(string categoryName)
        {
            string categoryIdSearchSql = "SELECT * FROM Categories WHERE CategoryName='" + categoryName + "'";
            SqlDataReader reader = this.dataAccess.GetData(categoryIdSearchSql);
            reader.Read();
            int categoryId = (int)reader["CategoryId"];
            return categoryId;
        }
        public List<Product> GetProductsByProductName(string productName)
        {
            string sql = "SELECT * FROM Products WHERE ProductName LIKE '"+productName+"%'";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product();
                product.ProductId = (int)reader["ProductId"];
                product.ProductName = reader["ProductName"].ToString();
                product.Price = Convert.ToDouble(reader["Price"]);
                product.Quantity = (int)reader["Quantity"];
                product.CategoryId = (int)reader["CategoryId"];
                products.Add(product);
            }
            return products;
        }

    }
}
