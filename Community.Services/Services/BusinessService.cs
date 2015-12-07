using Community.Domain.Models;
using Community.Domain.Repositories;
using Community.Services.ViewModels;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Services.Services
{
    public class BusinessService
    {
        private IRepository<Business> repository;

        public BusinessService()
        {
            repository = new Repository<Business>("Business");
        }


        public void Insert(Business business)
        {
            repository.Insert(business);
        }


        public async Task<Business> GetBusinessProfile(string businessID)
        {
            var filter = Builders<Business>.Filter.Eq("_id", new ObjectId(businessID));

            var result = await repository.GetCollection().Find(filter).SingleOrDefaultAsync();

            return result;
        }
    }
}
