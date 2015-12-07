using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Domain.Models
{
    public class Business : BaseEntity
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string WebSite { get; set; }

        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Country { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string City { get; set; }

        public string State { get; set; }

        public string ZIP { get; set; }

        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public IEnumerable<string> Images { get; set; }

        public IEnumerable<string> Categories { get; set; }
    }
}
