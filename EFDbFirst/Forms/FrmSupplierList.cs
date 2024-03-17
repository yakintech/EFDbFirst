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
    public partial class FrmSupplierList : Form
    {
        public FrmSupplierList()
        {
            InitializeComponent();
        }

        private void FrmSupplierList_Load(object sender, EventArgs e)
        {
            SupplierService supplierService = new SupplierService();
            dataGridView1.DataSource = supplierService.GetAllSuppliers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SupplierService supplierService = new SupplierService();
                supplierService.DeleteSupplier(id);
                dataGridView1.DataSource = supplierService.GetAllSuppliers();
            }
            catch (Exception)
            {

                MessageBox.Show("Supplier silme islemi sirasinda bir hata meydana geldi");
            }
        }
    }
}
