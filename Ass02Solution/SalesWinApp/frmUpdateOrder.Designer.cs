namespace SalesWinApp
{
    partial class frmUpdateOrder
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbUpdateOrderTittle = new System.Windows.Forms.Label();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRequiredDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShippedDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(518, 571);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 37);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(395, 571);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 37);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(71, 571);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 37);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbUpdateOrderTittle
            // 
            this.lbUpdateOrderTittle.AutoSize = true;
            this.lbUpdateOrderTittle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUpdateOrderTittle.Location = new System.Drawing.Point(204, 39);
            this.lbUpdateOrderTittle.Name = "lbUpdateOrderTittle";
            this.lbUpdateOrderTittle.Size = new System.Drawing.Size(238, 46);
            this.lbUpdateOrderTittle.TabIndex = 28;
            this.lbUpdateOrderTittle.Text = "Update Order";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(204, 271);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(407, 27);
            this.txtOrderDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Order Date:";
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(204, 333);
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.PasswordChar = '*';
            this.txtRequiredDate.Size = new System.Drawing.Size(407, 27);
            this.txtRequiredDate.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Required Date:";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(204, 463);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(407, 27);
            this.txtFreight.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 466);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Freight";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(204, 208);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(407, 27);
            this.txtMemberID.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "MemberID:";
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(204, 401);
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(407, 27);
            this.txtShippedDate.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Shipped Date:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(204, 151);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(407, 27);
            this.txtOrderID.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "OrderID:";
            // 
            // UpdateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 661);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbUpdateOrderTittle);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRequiredDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShippedDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Name = "UpdateOrder";
            this.Text = "UpdateOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private Button btnClear;
        private Label lbUpdateOrderTittle;
        private TextBox txtOrderDate;
        private Label label6;
        private TextBox txtRequiredDate;
        private Label label5;
        private TextBox txtFreight;
        private Label label4;
        private TextBox txtMemberID;
        private Label label3;
        private TextBox txtShippedDate;
        private Label label2;
        private TextBox txtOrderID;
        private Label label1;
    }
}