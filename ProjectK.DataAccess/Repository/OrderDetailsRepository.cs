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
    public class OrderDetailsRepository: Repository<OrderDetails>, IOrderDetailsRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderDetailsRepository(ApplicationDbContext context) : base(context)
        {
            _db = context;
        }
        public void Update(OrderDetails orderDetails)
        {
            var ObjFromDb = _db.OrderDetails.FirstOrDefault(u => u.Id == orderDetails.Id);
            ObjFromDb.Price = orderDetails.Price;
            ObjFromDb.Quantity = orderDetails.Quantity;
            ObjFromDb.ProductId = orderDetails.ProductId;
            ObjFromDb.OrderId = orderDetails.OrderId;
            

        }
    }
}
