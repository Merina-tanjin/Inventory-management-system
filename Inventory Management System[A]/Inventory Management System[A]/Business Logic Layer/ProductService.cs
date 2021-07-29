using Inventory_Management_System_A_.Data_Access_Layer;
using Inventory_Management_System_A_.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System_A_.Business_Logic_Layer
{
    class ProductService
    {
        ProductDataAccess productDataAccess;
        public ProductService()
        {
            this.productDataAccess = new ProductDataAccess();
        }
        public List<Product> GetProductsList()
        {
            return this.productDataAccess.GetAllProducts();
        }
        public int AddNewProduct(string productName,string price,string quantity,string categoryName)
        {
            int categoryId = this.productDataAccess.GetCategoryId(categoryName);
            Product product = new Product()
            {
                ProductName=productName,
                Price=Convert.ToDouble(price),
                Quantity=Convert.ToInt32(quantity),
                CategoryId=categoryId
            };
            productDataAccess = new ProductDataAccess();
            return this.productDataAccess.AddNewProduct(product);
        }
        public List<Product> GetProductsListForSearch(string productName)
        {
            return this.productDataAccess.GetProductsByProductName(productName);
        }
    }
}
