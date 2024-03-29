﻿namespace EFDbFirst.Forms
{
    partial class FrmSuppliers
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
            dtGridSuppliers = new DataGridView();
            btnOrderByCompanyName = new Button();
            tctCompanyNameSearch = new TextBox();
            label1 = new Label();
            txtTake = new TextBox();
            label2 = new Label();
            btnTake = new Button();
            btnDelete = new Button();
            label3 = new Label();
            txtCompanyName = new TextBox();
            label4 = new Label();
            txtContactName = new TextBox();
            label5 = new Label();
            txtContactTitle = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).BeginInit();
            SuspendLayout();
            // 
            // dtGridSuppliers
            // 
            dtGridSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridSuppliers.Location = new Point(12, 247);
            dtGridSuppliers.Name = "dtGridSuppliers";
            dtGridSuppliers.RowHeadersWidth = 62;
            dtGridSuppliers.Size = new Size(827, 505);
            dtGridSuppliers.TabIndex = 0;
            dtGridSuppliers.CellClick += dtGridSuppliers_CellClick;
            dtGridSuppliers.CellContentClick += dtGridSuppliers_CellContentClick;
            // 
            // btnOrderByCompanyName
            // 
            btnOrderByCompanyName.Location = new Point(12, 21);
            btnOrderByCompanyName.Name = "btnOrderByCompanyName";
            btnOrderByCompanyName.Size = new Size(305, 53);
            btnOrderByCompanyName.TabIndex = 1;
            btnOrderByCompanyName.Text = "Order By Company Name";
            btnOrderByCompanyName.UseVisualStyleBackColor = true;
            btnOrderByCompanyName.Click += btnOrderByCompanyName_Click;
            // 
            // tctCompanyNameSearch
            // 
            tctCompanyNameSearch.Location = new Point(421, 40);
            tctCompanyNameSearch.Name = "tctCompanyNameSearch";
            tctCompanyNameSearch.Size = new Size(150, 31);
            tctCompanyNameSearch.TabIndex = 2;
            tctCompanyNameSearch.TextChanged += tctCompanyNameSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 46);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 3;
            label1.Text = "Search:";
            // 
            // txtTake
            // 
            txtTake.Location = new Point(689, 39);
            txtTake.Name = "txtTake";
            txtTake.Size = new Size(150, 31);
            txtTake.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(634, 45);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 5;
            label2.Text = "Take:";
            // 
            // btnTake
            // 
            btnTake.Location = new Point(859, 37);
            btnTake.Name = "btnTake";
            btnTake.Size = new Size(112, 34);
            btnTake.TabIndex = 6;
            btnTake.Text = "Take";
            btnTake.TextAlign = ContentAlignment.BottomCenter;
            btnTake.UseVisualStyleBackColor = true;
            btnTake.Click += btnTake_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(12, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(928, 269);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 8;
            label3.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(1098, 263);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(310, 31);
            txtCompanyName.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(928, 334);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 8;
            label4.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(1098, 328);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(310, 31);
            txtContactName.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(928, 405);
            label5.Name = "label5";
            label5.Size = new Size(114, 25);
            label5.TabIndex = 8;
            label5.Text = "Contact Title:";
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(1098, 399);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(310, 31);
            txtContactTitle.TabIndex = 9;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(1136, 479);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FrmSuppliers
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1629, 782);
            Controls.Add(btnUpdate);
            Controls.Add(txtContactTitle);
            Controls.Add(label5);
            Controls.Add(txtContactName);
            Controls.Add(label4);
            Controls.Add(txtCompanyName);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnTake);
            Controls.Add(label2);
            Controls.Add(txtTake);
            Controls.Add(label1);
            Controls.Add(tctCompanyNameSearch);
            Controls.Add(btnOrderByCompanyName);
            Controls.Add(dtGridSuppliers);
            Name = "FrmSuppliers";
            Text = "FrmSuppliers";
            Load += FrmSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridSuppliers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtGridSuppliers;
        private Button btnOrderByCompanyName;
        private TextBox tctCompanyNameSearch;
        private Label label1;
        private TextBox txtTake;
        private Label label2;
        private Button btnTake;
        private Button btnDelete;
        private Label label3;
        private TextBox txtCompanyName;
        private Label label4;
        private TextBox txtContactName;
        private Label label5;
        private TextBox txtContactTitle;
        private Button btnUpdate;
    }
}