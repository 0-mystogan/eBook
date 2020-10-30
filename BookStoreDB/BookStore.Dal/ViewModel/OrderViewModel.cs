using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class OrderViewModel
    {
        public OrderViewModel(Order order)
        {
            Order = new OrderDto(order);
        }
        public OrderDto Order { get; set; }
    }
}
