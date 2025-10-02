using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models.Dtos
{
    public class TmdbConfigurationResponse
    {
        public TmdbImages images { get; set; }
        public string[] change_keys { get; set; }
    }
}
