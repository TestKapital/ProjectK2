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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _db = context;
        }

        public void Update(Product product)
        {
            var ObjFromDb = _db.Product.FirstOrDefault(u => u.Id == product.Id);
            ObjFromDb.Code = product.Code;
            ObjFromDb.Name = product.Name;
            ObjFromDb.Price = product.Price;
            ObjFromDb.Availability = product.Availability;         
            
        }
    }
}
