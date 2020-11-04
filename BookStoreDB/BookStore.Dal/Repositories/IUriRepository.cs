using BookStore.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Repositories
{
    public interface IUriRepository
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
