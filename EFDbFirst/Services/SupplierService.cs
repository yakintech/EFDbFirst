using EFDbFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbFirst.Services
{
    public class SupplierService
    {
        //get all suppliers
        public List<Supplier> GetAllSuppliers()
        {
            NorthwindContext context = new NorthwindContext();
            return context.Suppliers.ToList();
        }

        //delete supplier by id
        public void DeleteSupplier(int id)
        {
            NorthwindContext context = new NorthwindContext();
            Supplier supplier = context.Suppliers.Find(id);
            context.Suppliers.Remove(supplier);
            context.SaveChanges();
        }

        //add supplier
        public Supplier AddSupplier(Supplier supplier)
        {
            NorthwindContext db = new NorthwindContext();

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            return supplier;
        }
    }
}
