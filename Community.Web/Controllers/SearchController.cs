using Community.Services.Services;
using Community.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Community.Web.Controllers
{
    public class SearchController : Controller
    {
        private SearchService searchService = new SearchService();

        [HttpPost]
        public async Task<ActionResult> Result(SearchViewModel searchVM)
        {
            IEnumerable<SearchResultViewModel> searchResult = await searchService.GetSearchResult(searchVM);

           return View(searchResult);
        }
    }
}