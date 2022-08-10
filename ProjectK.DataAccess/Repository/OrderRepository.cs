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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext _db;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _db = context;
        }

        public void Update(Order order)
        {
            var ObjFromDb = _db.Order.FirstOrDefault(u => u.Id == order.Id);
            ObjFromDb.OrderDate = order.OrderDate;
            ObjFromDb.CustomerId = order.CustomerId;           

        }
    }
}
