using EFDbFirst.Models;
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
    public partial class FrmCreataeSupplier : Form
    {
        public FrmCreataeSupplier()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();

            Supplier supplier = new Supplier();
            supplier.CompanyName = txtCompanyName.Text.Trim();
            supplier.ContactName = txtContactName.Text.Trim();
            supplier.ContactTitle = txtContactTitle.Text.Trim();

            db.Suppliers.Add(supplier);
            db.SaveChanges();
            MessageBox.Show("Supplier added successfully");
        }
    }
}
