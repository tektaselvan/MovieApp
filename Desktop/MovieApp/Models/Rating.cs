using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string UserIdentifier { get; set; } // opsiyonel
        public byte RatingValue { get; set; } // 1..10
        public string Note { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
