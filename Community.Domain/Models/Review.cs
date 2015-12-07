using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Community.Domain.Models
{
    public class Review : BaseEntity
    {
        public ObjectId BusinessID { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }
    }
}
