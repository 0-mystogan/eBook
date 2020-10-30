using BookStore.Dal.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Dal.ViewModel
{
    public interface IBaseRepository<TEntity>where TEntity : BaseEntity
    {
        TEntity Add(TEntity entity);
        TEntity Remove(TEntity entity);
        TEntity Update(TEntity entity);
    }
}
