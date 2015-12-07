using Community.Domain.Models;
using Community.Services.Services;
using Community.Services.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;

namespace Community.Web.Controllers
{
    public class BusinessController : Controller
    {
        private BusinessService businessService = new BusinessService();

        public ActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Add(Business business)
        {
            if (ModelState.IsValid)
            {
                business.SetDate = DateTime.Now;
                businessService.Insert(business);

                return RedirectToAction("Index", "Home");
            }
            return View(business);
        }


        public async Task<ActionResult> GetBusinessProfile(string id)
        {
            Business business = await businessService.GetBusinessProfile(id);
            IEnumerable<Review> reviewList = new List<Review>();

            BusinessProfileViewModel profile = new BusinessProfileViewModel()
            {
                Business = business,
                ReviewList = reviewList
            };

            return View("BusinessProfile", profile);
        }
    }
}