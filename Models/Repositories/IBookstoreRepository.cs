using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.Repositories
{
    interface IBookstoreRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
