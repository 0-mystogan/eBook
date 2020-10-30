using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class OrderDto
    {
        public OrderDto()
        {

        }

        public OrderDto(Order order)
        {
            BookId = order.BookId;
            UserId = order.UserId;
            Quantity = order.Quantity;
            Total = order.Total;
            PaymantMethod = order.PaymantMethod;
        }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string PaymantMethod { get; set; }
    }
}
