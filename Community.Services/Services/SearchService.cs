using Community.Domain.Models;
using Community.Domain.Repositories;
using Community.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Community.Services.Services
{
    public class SearchService
    {
        private IRepository<Business> repository;


        public SearchService()
        {
            repository = new Repository<Business>("Business");
        }

        public async Task<IEnumerable<SearchResultViewModel>> GetSearchResult(SearchViewModel searchVM)
        {
            BsonDocument filter = new BsonDocument {
                                         { "$text", new BsonDocument {
                                                 { "$search", searchVM.What }
                                             }
                                         }
                                     };

            IEnumerable<Business> businessList = await repository.GetCollection().Find(filter).ToListAsync();

            var result = (from s in businessList
                          select new SearchResultViewModel
                          {
                              BusinessID = s.Id.ToString(),
                              Name = s.Name,
                              Description = s.Description
                          }).AsEnumerable();

            return result;
        }
    }
}
