using Community.Domain.Models;
using Community.Services.Services;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Community.Web.Controllers
{
    public class ReviewController : Controller
    {
        private ReviewService reviewService = new ReviewService();

        public ActionResult Index(string id)
        {
            return View("_AddReview", new Review() { BusinessID = new ObjectId(id) });
        }


        [HttpPost]
        public ActionResult AddReview(Review review)
        {
            review.SetDate = DateTime.Now;
            reviewService.Insert(review);

            return View();
        }
    }
}