using Community.Domain.Models;
using Community.Domain.Repositories;
using Community.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Services.Services
{
    public class CategoryService
    {
        private IRepository<Category> repository;

        public CategoryService()
        {
            repository = new Repository<Category>("Category");
        }


        public void Insert(Category category)
        {
            repository.Insert(category);
        }
    }
}
