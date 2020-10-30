using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Domain
{
    public class UserBook : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int Quatity { get; set; }
        public bool isWhishList { get; set; }
        public bool isCart { get; set; }
    }
}
