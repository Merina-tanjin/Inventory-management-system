namespace Inventory_Management_System_A_.Presentation_Layer
{
    partial class CategoryManagement
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
            this.loadCategoryDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.addCategoryNametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateCategoryButton = new System.Windows.Forms.Button();
            this.updateCategoryNametextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.deleteCategoryIdTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.categoryWiseProductListGridView = new System.Windows.Forms.DataGridView();
            this.categoryWiseSearchComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // loadCategoryDataGridView
            // 
            this.loadCategoryDataGridView.AllowUserToAddRows = false;
            this.loadCategoryDataGridView.AllowUserToDeleteRows = false;
            this.loadCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loadCategoryDataGridView.Location = new System.Drawing.Point(481, 48);
            this.loadCategoryDataGridView.Name = "loadCategoryDataGridView";
            this.loadCategoryDataGridView.ReadOnly = true;
            this.loadCategoryDataGridView.Size = new System.Drawing.Size(240, 150);
            this.loadCategoryDataGridView.TabIndex = 0;
            this.loadCategoryDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loadCategoryDataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of categories";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addCategoryButton);
            this.groupBox1.Controls.Add(this.addCategoryNametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Category";
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.Location = new System.Drawing.Point(154, 98);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(157, 34);
            this.addCategoryButton.TabIndex = 2;
            this.addCategoryButton.Text = "Add Category";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // addCategoryNametextBox
            // 
            this.addCategoryNametextBox.Location = new System.Drawing.Point(154, 49);
            this.addCategoryNametextBox.Name = "addCategoryNametextBox";
            this.addCategoryNametextBox.Size = new System.Drawing.Size(157, 30);
            this.addCategoryNametextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateCategoryButton);
            this.groupBox2.Controls.Add(this.updateCategoryNametextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 148);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Category";
            // 
            // updateCategoryButton
            // 
            this.updateCategoryButton.Location = new System.Drawing.Point(154, 98);
            this.updateCategoryButton.Name = "updateCategoryButton";
            this.updateCategoryButton.Size = new System.Drawing.Size(157, 34);
            this.updateCategoryButton.TabIndex = 2;
            this.updateCategoryButton.Text = "Save";
            this.updateCategoryButton.UseVisualStyleBackColor = true;
            this.updateCategoryButton.Click += new System.EventHandler(this.updateCategoryButton_Click);
            // 
            // updateCategoryNametextBox
            // 
            this.updateCategoryNametextBox.Location = new System.Drawing.Point(154, 49);
            this.updateCategoryNametextBox.Name = "updateCategoryNametextBox";
            this.updateCategoryNametextBox.Size = new System.Drawing.Size(157, 30);
            this.updateCategoryNametextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.deleteCategoryButton);
            this.groupBox3.Controls.Add(this.deleteCategoryIdTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(35, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 148);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Delete Category";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.Location = new System.Drawing.Point(154, 98);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(157, 34);
            this.deleteCategoryButton.TabIndex = 2;
            this.deleteCategoryButton.Text = "Delete";
            this.deleteCategoryButton.UseVisualStyleBackColor = true;
            this.deleteCategoryButton.Click += new System.EventHandler(this.deleteCategoryButton_Click);
            // 
            // deleteCategoryIdTextBox
            // 
            this.deleteCategoryIdTextBox.Location = new System.Drawing.Point(154, 49);
            this.deleteCategoryIdTextBox.Name = "deleteCategoryIdTextBox";
            this.deleteCategoryIdTextBox.Size = new System.Drawing.Size(157, 30);
            this.deleteCategoryIdTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.categoryWiseProductListGridView);
            this.groupBox4.Controls.Add(this.categoryWiseSearchComboBox);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(392, 250);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(490, 300);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Category Wise Product LIst";
            // 
            // categoryWiseProductListGridView
            // 
            this.categoryWiseProductListGridView.AllowUserToAddRows = false;
            this.categoryWiseProductListGridView.AllowUserToDeleteRows = false;
            this.categoryWiseProductListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryWiseProductListGridView.Location = new System.Drawing.Point(23, 81);
            this.categoryWiseProductListGridView.Name = "categoryWiseProductListGridView";
            this.categoryWiseProductListGridView.ReadOnly = true;
            this.categoryWiseProductListGridView.Size = new System.Drawing.Size(448, 203);
            this.categoryWiseProductListGridView.TabIndex = 5;
            // 
            // categoryWiseSearchComboBox
            // 
            this.categoryWiseSearchComboBox.FormattingEnabled = true;
            this.categoryWiseSearchComboBox.Location = new System.Drawing.Point(190, 41);
            this.categoryWiseSearchComboBox.Name = "categoryWiseSearchComboBox";
            this.categoryWiseSearchComboBox.Size = new System.Drawing.Size(196, 27);
            this.categoryWiseSearchComboBox.TabIndex = 4;
            this.categoryWiseSearchComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryWiseSearchComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Category Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(807, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CategoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadCategoryDataGridView);
            this.Name = "CategoryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CategoryManagement_FormClosing);
            this.Load += new System.EventHandler(this.CategoryManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadCategoryDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWiseProductListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView loadCategoryDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.TextBox addCategoryNametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateCategoryButton;
        private System.Windows.Forms.TextBox updateCategoryNametextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button deleteCategoryButton;
        private System.Windows.Forms.TextBox deleteCategoryIdTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView categoryWiseProductListGridView;
        private System.Windows.Forms.ComboBox categoryWiseSearchComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}