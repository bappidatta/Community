using Community.Domain.Models;
using Community.Domain.Repositories;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Services.Services
{
    public class ReviewService
    {
        private IRepository<Review> repository;

        public ReviewService()
        {
            repository = new Repository<Review>("Review");
        }


        public void Insert(Review review)
        {
            repository.Insert(review);
        }


        public async Task<IEnumerable<Review>> GetAllReview(string businessID)
        {
            var filter = Builders<Review>.Filter.Eq("BusinessID", businessID);

            IEnumerable<Review> reviewList = await repository.GetCollection().Find(filter).ToListAsync();

            return reviewList;
        }
    }
}
