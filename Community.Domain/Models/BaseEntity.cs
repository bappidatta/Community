using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Community.Domain.Models
{
    public class BaseEntity
    {
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public DateTime SetDate { get; set; }
        public Boolean IsApproved { get; set; }
    }
}
