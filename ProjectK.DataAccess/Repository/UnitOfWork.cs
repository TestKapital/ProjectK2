using ProjectK.DataAccess.Data;
using ProjectK.DataAccess.Repository.IRepository;
using ProjectK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectK.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Customer = new CustomerRepository(_db);
            CustomerCategory = new CustomerCategoryRepository(_db);
            Product = new ProductRepository(_db);
            Order = new OrderRepository(_db);
            OrderDetails = new OrderDetailsRepository(_db);

        }

        public ICustomerRepository Customer {get; private set;}
        public ICustomerCategoryRepository CustomerCategory {get; private set; }
        public IProductRepository Product {get; private set; }
        public IOrderRepository Order {get; private set; }
        public IOrderDetailsRepository OrderDetails {get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
