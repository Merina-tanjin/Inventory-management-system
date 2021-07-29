namespace Inventory_Management_System_A_.Presentation_Layer
{
    partial class ProductManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfProductsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.addProductButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchProductTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchProductGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listOfProductsGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfProductsGridView
            // 
            this.listOfProductsGridView.AllowUserToAddRows = false;
            this.listOfProductsGridView.AllowUserToDeleteRows = false;
            this.listOfProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOfProductsGridView.Location = new System.Drawing.Point(516, 59);
            this.listOfProductsGridView.Name = "listOfProductsGridView";
            this.listOfProductsGridView.ReadOnly = true;
            this.listOfProductsGridView.Size = new System.Drawing.Size(365, 153);
            this.listOfProductsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(635, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of Products";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addProductButton);
            this.groupBox1.Controls.Add(this.addProductCategoryComboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.addQuantityTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addPriceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.addProductNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 256);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Product Name";
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(180, 44);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(196, 26);
            this.addProductNameTextBox.TabIndex = 1;
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.Location = new System.Drawing.Point(180, 87);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(196, 26);
            this.addPriceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price";
            // 
            // addQuantityTextBox
            // 
            this.addQuantityTextBox.Location = new System.Drawing.Point(180, 127);
            this.addQuantityTextBox.Name = "addQuantityTextBox";
            this.addQuantityTextBox.Size = new System.Drawing.Size(196, 26);
            this.addQuantityTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category";
            // 
            // addProductCategoryComboBox
            // 
            this.addProductCategoryComboBox.FormattingEnabled = true;
            this.addProductCategoryComboBox.Location = new System.Drawing.Point(180, 168);
            this.addProductCategoryComboBox.Name = "addProductCategoryComboBox";
            this.addProductCategoryComboBox.Size = new System.Drawing.Size(196, 27);
            this.addProductCategoryComboBox.TabIndex = 7;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(180, 206);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(196, 36);
            this.addProductButton.TabIndex = 8;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchProductGridView);
            this.groupBox2.Controls.Add(this.searchProductTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(459, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 254);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Product";
            // 
            // searchProductTextBox
            // 
            this.searchProductTextBox.Location = new System.Drawing.Point(198, 35);
            this.searchProductTextBox.Name = "searchProductTextBox";
            this.searchProductTextBox.Size = new System.Drawing.Size(196, 26);
            this.searchProductTextBox.TabIndex = 10;
            this.searchProductTextBox.TextChanged += new System.EventHandler(this.searchProductTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Product Name";
            // 
            // searchProductGridView
            // 
            this.searchProductGridView.AllowUserToAddRows = false;
            this.searchProductGridView.AllowUserToDeleteRows = false;
            this.searchProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchProductGridView.Location = new System.Drawing.Point(25, 78);
            this.searchProductGridView.Name = "searchProductGridView";
            this.searchProductGridView.ReadOnly = true;
            this.searchProductGridView.Size = new System.Drawing.Size(397, 170);
            this.searchProductGridView.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(850, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listOfProductsGridView);
            this.Name = "ProductManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductManagement_FormClosing);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listOfProductsGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listOfProductsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.ComboBox addProductCategoryComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addQuantityTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProductNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView searchProductGridView;
        private System.Windows.Forms.TextBox searchProductTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}