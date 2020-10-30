using BookStore.Dal.Context;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.ViewModel
{
    public class SqlServerOrderRepository : IOrderRepository
    {
        private readonly BookStoreDbContext _bookStoreDbContext;

        public SqlServerOrderRepository(BookStoreDbContext bookStoreDbContext)
        {
            _bookStoreDbContext = bookStoreDbContext;
        }

        public async Task<List<Order>> GetOrders(int id, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            List<Order> Orders = await _bookStoreDbContext.Orders.Take(maxTop).Where(u => u.UserId == id).ToListAsync(cancellationToken);
          
            return Orders;
        }

    }
}
