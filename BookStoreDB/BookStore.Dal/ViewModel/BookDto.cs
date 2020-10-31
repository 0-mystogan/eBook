using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.ViewModel
{
    public class BookDto
    {
        public BookDto()
        {

        }
        public BookDto(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Author = book.Author;
            Description = book.Description;
            Price = book.Price;
            Currrency = book.Currrency;
            Quantity = book.Quantity;
            Image = book.Image;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Currrency { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
