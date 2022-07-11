namespace SalesWinApp
{
    partial class frmOrders
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.f = new System.Windows.Forms.Label();
            this.l6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtOrderDate = new System.Windows.Forms.DateTimePicker();
            this.txtShippedDate = new System.Windows.Forms.DateTimePicker();
            this.btnView = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.orderDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequiredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShippedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Freight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSort = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(77, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "OrderID";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderID.Location = new System.Drawing.Point(196, 34);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(165, 29);
            this.txtOrderID.TabIndex = 1;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMemberID.Location = new System.Drawing.Point(196, 111);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(165, 29);
            this.txtMemberID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(77, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "MemberID";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l3.Location = new System.Drawing.Point(457, 34);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(83, 21);
            this.l3.TabIndex = 4;
            this.l3.Text = "OrderDate";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l4.Location = new System.Drawing.Point(435, 114);
            this.l4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(105, 21);
            this.l4.TabIndex = 6;
            this.l4.Text = "RequiredDate";
            // 
            // txtFreight
            // 
            this.txtFreight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFreight.Location = new System.Drawing.Point(936, 111);
            this.txtFreight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(200, 29);
            this.txtFreight.TabIndex = 11;
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.f.Location = new System.Drawing.Point(828, 111);
            this.f.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(59, 21);
            this.f.TabIndex = 10;
            this.f.Text = "Freight";
            // 
            // l6
            // 
            this.l6.AutoSize = true;
            this.l6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l6.Location = new System.Drawing.Point(788, 34);
            this.l6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l6.Name = "l6";
            this.l6.Size = new System.Drawing.Size(99, 21);
            this.l6.TabIndex = 8;
            this.l6.Text = "ShippedDate";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtRequiredDate);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.txtShippedDate);
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.txtFreight);
            this.panel1.Controls.Add(this.f);
            this.panel1.Controls.Add(this.l6);
            this.panel1.Controls.Add(this.l4);
            this.panel1.Controls.Add(this.l3);
            this.panel1.Controls.Add(this.txtMemberID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 39);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 217);
            this.panel1.TabIndex = 12;
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(574, 114);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(200, 29);
            this.txtRequiredDate.TabIndex = 15;
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(574, 31);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(200, 29);
            this.txtOrderDate.TabIndex = 14;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(936, 34);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(200, 29);
            this.txtShippedDate.TabIndex = 13;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnView.Location = new System.Drawing.Point(991, 160);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(130, 41);
            this.btnView.TabIndex = 12;
            this.btnView.Text = "View Detail";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(737, 311);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 40);
            this.btnLoad.TabIndex = 13;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(1003, 311);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(1133, 311);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(874, 311);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 41);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MemberId,
            this.OrderDate,
            this.RequiredDate,
            this.ShippedDate,
            this.Freight});
            this.dgvOrderList.Location = new System.Drawing.Point(135, 399);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.RowHeadersWidth = 51;
            this.dgvOrderList.RowTemplate.Height = 29;
            this.dgvOrderList.Size = new System.Drawing.Size(1141, 262);
            this.dgvOrderList.TabIndex = 18;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "OrderID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 175;
            // 
            // MemberId
            // 
            this.MemberId.DataPropertyName = "MemberId";
            this.MemberId.HeaderText = "MemberID";
            this.MemberId.MinimumWidth = 6;
            this.MemberId.Name = "MemberId";
            this.MemberId.Width = 175;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "OrderDate";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 210;
            // 
            // RequiredDate
            // 
            this.RequiredDate.DataPropertyName = "RequiredDate";
            this.RequiredDate.HeaderText = "RequiredDate";
            this.RequiredDate.MinimumWidth = 6;
            this.RequiredDate.Name = "RequiredDate";
            this.RequiredDate.Width = 210;
            // 
            // ShippedDate
            // 
            this.ShippedDate.DataPropertyName = "ShippedDate";
            this.ShippedDate.HeaderText = "ShippedDate";
            this.ShippedDate.MinimumWidth = 6;
            this.ShippedDate.Name = "ShippedDate";
            this.ShippedDate.Width = 210;
            // 
            // Freight
            // 
            this.Freight.DataPropertyName = "Freight";
            this.Freight.HeaderText = "Freight";
            this.Freight.MinimumWidth = 6;
            this.Freight.Name = "Freight";
            this.Freight.Width = 150;
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(525, 305);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(129, 53);
            this.btnSort.TabIndex = 19;
            this.btnSort.Text = "Sort by Descending Date";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(102, 63);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(230, 29);
            this.txtEndDate.TabIndex = 85;
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(102, 28);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(230, 29);
            this.txtStartDate.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 82;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 81;
            this.label4.Text = "Start Date";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.txtEndDate);
            this.groupBoxSearch.Controls.Add(this.btnFilter);
            this.groupBoxSearch.Controls.Add(this.txtStartDate);
            this.groupBoxSearch.Controls.Add(this.label5);
            this.groupBoxSearch.Controls.Add(this.label4);
            this.groupBoxSearch.Location = new System.Drawing.Point(42, 277);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(443, 99);
            this.groupBoxSearch.TabIndex = 83;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Report statistics sales";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(353, 42);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 32);
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1300, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1300, 700);
            this.Name = "frmOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmOrders";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtOrderID;
        private TextBox txtMemberID;
        private Label label2;
        private Label l3;
        private Label l4;
        private TextBox txtFreight;
        private Label f;
        private Label l6;
        private Panel panel1;
        private Button btnLoad;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource orderDAOBindingSource;
        private Button btnAdd;
        private DataGridView dgvOrderList;
        private Button btnView;
        private DateTimePicker txtShippedDate;
        private DateTimePicker txtRequiredDate;
        private DateTimePicker txtOrderDate;
        private Button btnSort;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn MemberId;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn RequiredDate;
        private DataGridViewTextBoxColumn ShippedDate;
        private DataGridViewTextBoxColumn Freight;
        private DateTimePicker txtEndDate;
        private DateTimePicker txtStartDate;
        private Label label5;
        private Label label4;
        private GroupBox groupBoxSearch;
        private Button btnFilter;
    }
}