namespace SalesWinApp
{
    partial class frmProducts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Input_Search = new System.Windows.Forms.TextBox();
            this.Input_ProductID = new System.Windows.Forms.TextBox();
            this.Input_CategoryID = new System.Windows.Forms.TextBox();
            this.Input_Weight = new System.Windows.Forms.TextBox();
            this.Input_UnitPrice = new System.Windows.Forms.TextBox();
            this.Input_ProductName = new System.Windows.Forms.TextBox();
            this.Input_UnitInStock = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.CategoryID,
            this.ProductName,
            this.Weight,
            this.UnitPrice,
            this.UnitInStock});
            this.dataGridView1.Location = new System.Drawing.Point(106, 311);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(803, 276);
            this.dataGridView1.TabIndex = 2;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.Width = 125;
            // 
            // CategoryID
            // 
            this.CategoryID.HeaderText = "CategoryID";
            this.CategoryID.MinimumWidth = 6;
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.Width = 125;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 125;
            // 
            // Weight
            // 
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.Width = 125;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 125;
            // 
            // UnitInStock
            // 
            this.UnitInStock.HeaderText = "UnitInStock";
            this.UnitInStock.MinimumWidth = 6;
            this.UnitInStock.Name = "UnitInStock";
            this.UnitInStock.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.ordersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenuItem
            // 
            this.memberToolStripMenuItem.Name = "memberToolStripMenuItem";
            this.memberToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.memberToolStripMenuItem.Text = "Member";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // Input_Search
            // 
            this.Input_Search.Location = new System.Drawing.Point(488, 247);
            this.Input_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Search.Multiline = true;
            this.Input_Search.Name = "Input_Search";
            this.Input_Search.Size = new System.Drawing.Size(316, 38);
            this.Input_Search.TabIndex = 6;
            // 
            // Input_ProductID
            // 
            this.Input_ProductID.Location = new System.Drawing.Point(87, 11);
            this.Input_ProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_ProductID.Multiline = true;
            this.Input_ProductID.Name = "Input_ProductID";
            this.Input_ProductID.Size = new System.Drawing.Size(182, 40);
            this.Input_ProductID.TabIndex = 8;
            // 
            // Input_CategoryID
            // 
            this.Input_CategoryID.Location = new System.Drawing.Point(378, 11);
            this.Input_CategoryID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CategoryID.Multiline = true;
            this.Input_CategoryID.Name = "Input_CategoryID";
            this.Input_CategoryID.Size = new System.Drawing.Size(203, 40);
            this.Input_CategoryID.TabIndex = 9;
            // 
            // Input_Weight
            // 
            this.Input_Weight.Location = new System.Drawing.Point(87, 98);
            this.Input_Weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Weight.Multiline = true;
            this.Input_Weight.Name = "Input_Weight";
            this.Input_Weight.Size = new System.Drawing.Size(182, 36);
            this.Input_Weight.TabIndex = 10;
            // 
            // Input_UnitPrice
            // 
            this.Input_UnitPrice.Location = new System.Drawing.Point(378, 98);
            this.Input_UnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_UnitPrice.Multiline = true;
            this.Input_UnitPrice.Name = "Input_UnitPrice";
            this.Input_UnitPrice.Size = new System.Drawing.Size(203, 36);
            this.Input_UnitPrice.TabIndex = 11;
            this.Input_UnitPrice.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Input_ProductName
            // 
            this.Input_ProductName.Location = new System.Drawing.Point(700, 11);
            this.Input_ProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_ProductName.Multiline = true;
            this.Input_ProductName.Name = "Input_ProductName";
            this.Input_ProductName.Size = new System.Drawing.Size(189, 40);
            this.Input_ProductName.TabIndex = 12;
            // 
            // Input_UnitInStock
            // 
            this.Input_UnitInStock.Location = new System.Drawing.Point(700, 98);
            this.Input_UnitInStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_UnitInStock.Multiline = true;
            this.Input_UnitInStock.Name = "Input_UnitInStock";
            this.Input_UnitInStock.Size = new System.Drawing.Size(189, 36);
            this.Input_UnitInStock.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "ProductID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "CategoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Weight";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "UnitPrice";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(597, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "ProductName";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(610, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "UnitInStock";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Input_UnitInStock);
            this.panel1.Controls.Add(this.Input_ProductName);
            this.panel1.Controls.Add(this.Input_UnitPrice);
            this.panel1.Controls.Add(this.Input_Weight);
            this.panel1.Controls.Add(this.Input_CategoryID);
            this.panel1.Controls.Add(this.Input_ProductID);
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 156);
            this.panel1.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(810, 247);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 38);
            this.btnSearch.TabIndex = 22;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(12, 530);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(86, 31);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(12, 437);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(86, 31);
            this.btn_Update.TabIndex = 24;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(12, 350);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 31);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // frmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Input_Search);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProducts";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem memberToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private TextBox Input_Search;
        private TextBox Input_ProductID;
        private TextBox Input_CategoryID;
        private TextBox Input_Weight;
        private TextBox Input_UnitPrice;
        private TextBox Input_ProductName;
        private TextBox Input_UnitInStock;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn ProductID;
        private DataGridViewTextBoxColumn CategoryID;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn Weight;
        private DataGridViewTextBoxColumn UnitPrice;
        private DataGridViewTextBoxColumn UnitInStock;
        private Button btnDelete;
        private Button btn_Update;
        private Button btnAdd;
    }
}