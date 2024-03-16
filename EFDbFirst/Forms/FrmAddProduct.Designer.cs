namespace EFDbFirst.Forms
{
    partial class FrmAddProduct
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
            btnAdd = new Button();
            txtUnitPrice = new TextBox();
            txtStock = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbCategories = new ComboBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(253, 271);
            btnAdd.Name = "btnAdd";
            btnAdd.RightToLeft = RightToLeft.Yes;
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(183, 207);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(182, 31);
            txtUnitPrice.TabIndex = 9;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(183, 158);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(182, 31);
            txtStock.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(183, 103);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 31);
            txtName.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 207);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 5;
            label4.Text = "Unit Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 158);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 6;
            label3.Text = "Stock:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 103);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 7;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 51);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 8;
            label1.Text = "Categories:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(183, 43);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(182, 33);
            cmbCategories.TabIndex = 4;
            // 
            // FrmAddProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStock);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Name = "FrmAddProduct";
            Text = "FrmAddProduct";
            Load += FrmAddProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox txtUnitPrice;
        private TextBox txtStock;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbCategories;
    }
}