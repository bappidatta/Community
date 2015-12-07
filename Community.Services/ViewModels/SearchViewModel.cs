using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Community.Services.ViewModels
{
    public class SearchViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string What { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Where { get; set; }
    }
}
