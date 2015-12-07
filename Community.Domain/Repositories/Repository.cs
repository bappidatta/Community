using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Domain.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private string _collectionName;

        public Repository(string collectionName)
        {
            this._collectionName = collectionName;
        }


        public IMongoCollection<T> GetCollection()
        {
            IMongoClient client = new MongoClient("mongodb://localhost:27017");
            IMongoDatabase database = client.GetDatabase("community");
            IMongoCollection<T> collection = database.GetCollection<T>(_collectionName);

            return collection;
        }


        public void Insert(T entity)
        {
            this.GetCollection().InsertOneAsync(entity);
        }


        public void Insert(IEnumerable<T> entities)
        {
            this.GetCollection().InsertManyAsync(entities);
        }
    }
}
