
using BookStore.Dal.Domain;
using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Currrency { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public byte[] Image { get; set; }
        public int Quantity { get; set; }
        public IList<BookCategory> BookCategories { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<Cart> Carts { get; set; }
    }
}