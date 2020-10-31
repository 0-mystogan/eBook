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

        public async Task<List<OrderViewModel>> AddOrder(OrderDto order, CancellationToken cancellationToken = default)
        {
            var user = new User();
            user = _bookStoreDbContext.Users.FirstOrDefault(u => u.Id == order.UserId);
            var orderDomain = new Order
            {
                UserId = order.UserId,
                User = user,
                BookId = order.BookId,
                Book = _bookStoreDbContext.Books.FirstOrDefault(b => b.Id == order.BookId),
                Quatity = order.Quantity,
                PaymantMethod = order.PaymantMethod,
                CreatedBy = _bookStoreDbContext.Users.FirstOrDefault(u => u.Id == order.UserId).ToString()
            };
            await _bookStoreDbContext.Orders.AddAsync(orderDomain, cancellationToken);
            await _bookStoreDbContext.SaveChangesAsync(cancellationToken);
            UserDto userDto = new UserDto(user);
            return await GetOrders(userDto);
        }

        public async Task<List<OrderViewModel>> GetOrders(UserDto user, CancellationToken cancellationToken = default)
        {
            const int maxTop = 10;
            List<Order> Orders = await _bookStoreDbContext.Orders.Take(maxTop).Where(u => u.UserId == user.Id).ToListAsync(cancellationToken);
            List<OrderViewModel> orderViewModels = new List<OrderViewModel>();
            foreach (var order in Orders)
            {
                orderViewModels.Add(new OrderViewModel(order));
            }
            return orderViewModels;
        }

    }
}
