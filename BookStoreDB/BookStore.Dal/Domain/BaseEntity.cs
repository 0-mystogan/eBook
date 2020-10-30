using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Domain
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string CreatedBy { get; set; }

        public BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
