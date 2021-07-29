using Inventory_Management_System_A_.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Management_System_A_.Presentation_Layer
{
    public partial class ProductManagement : Form
    {
        Home home;
        public ProductManagement(Home home)
        {
            this.home = home;
            InitializeComponent();
            addProductButton.Click += this.RefreshGridView;
        }

        private void ProductManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        void RefreshGridView(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            listOfProductsGridView.DataSource = productService.GetProductsList();
        }
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            listOfProductsGridView.DataSource = productService.GetProductsList();
            CategoryService categoryService = new CategoryService();
            addProductCategoryComboBox.DataSource = categoryService.GetCategoryNameList();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            int result = productService.AddNewProduct(addProductNameTextBox.Text,addPriceTextBox.Text,addQuantityTextBox.Text,addProductCategoryComboBox.Text);
            if (result > 0)
            {
                MessageBox.Show("New product added successfully");
                
            }
            else
            {
                MessageBox.Show("Error in adding new product");
            }
        }

        private void searchProductTextBox_TextChanged(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            searchProductGridView.DataSource = productService.GetProductsListForSearch(searchProductTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }
    }
}
