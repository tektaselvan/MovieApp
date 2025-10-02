using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class TmdbImages
    {
        public string base_url { get; set; }
        public string secure_base_url { get; set; }
        public string[] poster_sizes { get; set; }
        public string[] backdrop_sizes { get; set; }
    }
}
