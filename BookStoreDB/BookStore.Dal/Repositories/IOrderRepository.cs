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
        Task<List<Order>> GetOrders(int id, CancellationToken cancellationToken = default);
    }
}
