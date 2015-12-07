using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.Domain.Models;

namespace Community.Services.ViewModels
{
    public class BusinessProfileViewModel
    {
        public Business Business { get; set; }
        public IEnumerable<Review> ReviewList { get; set; }
    }
}
