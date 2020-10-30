using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public DateTime Date { get; set; }
        public int Quatity { get; set; }
        public decimal Total { get; set; }
        public string PaymantMethod { get; set; }
    }
}
