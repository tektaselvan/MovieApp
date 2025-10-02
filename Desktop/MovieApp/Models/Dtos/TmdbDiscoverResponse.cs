using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Dtos
{
    public class TmdbDiscoverResponse
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }
        public List<TmdbMovie> results { get; set; }
    }
}
