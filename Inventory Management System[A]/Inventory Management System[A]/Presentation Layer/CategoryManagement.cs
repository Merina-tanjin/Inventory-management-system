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
    public partial class CategoryManagement : Form
    {
        Home home;
        public CategoryManagement(Home home)
        {
            this.home = home;
            InitializeComponent();
            addCategoryButton.Click += this.RefreshGridView;
            updateCategoryButton.Click += this.RefreshGridView;
            deleteCategoryButton.Click += this.RefreshGridView;
        }

        private void CategoryManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CategoryManagement_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            loadCategoryDataGridView.DataSource = categoryService.GetCategoryList();
            categoryService = new CategoryService();
            categoryWiseSearchComboBox.DataSource = categoryService.GetCategoryNameList();
        }

        private void RefreshGridView(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            loadCategoryDataGridView.DataSource = categoryService.GetCategoryList();
            categoryService = new CategoryService();
            categoryWiseSearchComboBox.DataSource = categoryService.GetCategoryNameList();
        }
        private void ClearInputFiels ()
        {
            addCategoryNametextBox.Text = updateCategoryNametextBox.Text= deleteCategoryIdTextBox.Text= string.Empty;
        }


        private void addCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            int result = categoryService.AddNewCategory(addCategoryNametextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("New category added successfully");
                ClearInputFiels();
            }
            else
            {
                MessageBox.Show("Error in adding new category");
            }
        }
        int id = 0;
        private void loadCategoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =(int) loadCategoryDataGridView.Rows[e.RowIndex].Cells[0].Value;
            updateCategoryNametextBox.Text= loadCategoryDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            int result = categoryService.UpdateCategory(id,updateCategoryNametextBox.Text);
            if (result > 0)
            {
                MessageBox.Show("Category updated successfully");
                ClearInputFiels();
            }
            else
            {
                MessageBox.Show("Error in updating category");
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            int result = categoryService.DeleteCategory(Convert.ToInt32(deleteCategoryIdTextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Category deleted successfully");
                ClearInputFiels();
            }
            else
            {
                MessageBox.Show("Error in deleting category");
            }
        }

        private void categoryWiseSearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            categoryWiseProductListGridView.DataSource = categoryService.GetProductListByCategory(categoryWiseSearchComboBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Hide();
        }
    }
}
