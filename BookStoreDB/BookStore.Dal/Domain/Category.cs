
using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Domain
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
