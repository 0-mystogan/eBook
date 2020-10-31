using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookStore.Dal.ViewModel
{
    public interface IOrderRepository
    {
        Task<List<OrderViewModel>> GetOrders(UserDto user, CancellationToken cancellationToken = default);
        Task<List<OrderViewModel>> AddOrder(OrderDto order, CancellationToken cancellationToken = default);
    }
}
