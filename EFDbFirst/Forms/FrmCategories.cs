using EFDbFirst.Models;
using EFDbFirst.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFDbFirst.Forms
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        private void FrmCategories_Load(object sender, EventArgs e)
        {
            CategoryService categoryService = new CategoryService();
            dataGridView1.DataSource = categoryService.GetAllCategories();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedCategoryId = (int)dataGridView1.CurrentRow.Cells[0].Value;

                CategoryService categoryService = new CategoryService();
                categoryService.DeleteCategory(selectedCategoryId);
                dataGridView1.DataSource = categoryService.GetAllCategories();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show("Kategori silerken bir haya meydana geldi");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedCategoryId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            CategoryService categoryService = new CategoryService();
            Category category = categoryService.GetCategoryById(selectedCategoryId);

            txtName.Text = category.CategoryName;
            txtDescription.Text = category.Description;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
