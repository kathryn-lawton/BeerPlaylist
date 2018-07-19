using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
    public class Survey
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string CalculatedBeer { get; set; }
    }
}