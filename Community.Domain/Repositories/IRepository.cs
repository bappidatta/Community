using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Domain.Repositories
{
    public interface IRepository<T>
    {
        IMongoCollection<T> GetCollection();
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
    }
}
