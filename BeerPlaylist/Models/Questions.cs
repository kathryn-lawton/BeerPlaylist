using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
    public class Questions
    {
        [Key]
        public int QuestionID { get; set; }
        public string Answer { get; set; }
        public string QuestionText { get; set; }

    }
}