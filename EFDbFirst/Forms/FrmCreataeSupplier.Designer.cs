namespace EFDbFirst.Forms
{
    partial class FrmCreataeSupplier
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
            label1 = new Label();
            txtCompanyName = new TextBox();
            label2 = new Label();
            txtContactName = new TextBox();
            label3 = new Label();
            txtContactTitle = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 76);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 0;
            label1.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(250, 70);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(150, 31);
            txtCompanyName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 133);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 0;
            label2.Text = "Contact Name:";
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(250, 127);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(150, 31);
            txtContactName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 201);
            label3.Name = "label3";
            label3.Size = new Size(114, 25);
            label3.TabIndex = 0;
            label3.Text = "Contact Title:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtContactTitle
            // 
            txtContactTitle.Location = new Point(250, 195);
            txtContactTitle.Name = "txtContactTitle";
            txtContactTitle.Size = new Size(150, 31);
            txtContactTitle.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(288, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FrmCreataeSupplier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 384);
            Controls.Add(btnAdd);
            Controls.Add(txtContactTitle);
            Controls.Add(label3);
            Controls.Add(txtContactName);
            Controls.Add(label2);
            Controls.Add(txtCompanyName);
            Controls.Add(label1);
            Name = "FrmCreataeSupplier";
            Text = "FrmCreataeSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCompanyName;
        private Label label2;
        private TextBox txtContactName;
        private Label label3;
        private TextBox txtContactTitle;
        private Button btnAdd;
    }
}