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
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
        }

        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }


        void LoadSuppliers()
        {
            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void btnOrderByCompanyName_Click(object sender, EventArgs e)
        {
            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.OrderBy(x => x.CompanyName).ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void tctCompanyNameSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tctCompanyNameSearch.Text;

            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.Where(x => x.CompanyName.StartsWith(search)).ToList();
            dtGridSuppliers.DataSource = suppliers;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            int take = Convert.ToInt32(txtTake.Text);

            NorthwindContext db = new NorthwindContext();
            List<Supplier> suppliers = db.Suppliers.Take(take).ToList();
            dtGridSuppliers.DataSource = suppliers;


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get selected id from grid cell   
            int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);

            NorthwindContext db = new NorthwindContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);

            if (supplier != null)
            {
                db.Suppliers.Remove(supplier);
                db.SaveChanges();
                LoadSuppliers();
            }
        }

        private void dtGridSuppliers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtGridSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);

            NorthwindContext db = new NorthwindContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);

            if (supplier != null)
            {
                txtCompanyName.Text = supplier.CompanyName;
                txtContactName.Text = supplier.ContactName;
                txtContactTitle.Text = supplier.ContactTitle;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dtGridSuppliers.CurrentRow.Cells[0].Value);

            NorthwindContext db = new NorthwindContext();
            Supplier supplier = db.Suppliers.FirstOrDefault(x => x.SupplierId == id);
            supplier.CompanyName = txtCompanyName.Text;
            supplier.ContactName = txtContactName.Text;
            supplier.ContactTitle = txtContactTitle.Text;

            db.SaveChanges();
            LoadSuppliers();
        }
    }
}

// where, take, orderBy, orderByDesc
