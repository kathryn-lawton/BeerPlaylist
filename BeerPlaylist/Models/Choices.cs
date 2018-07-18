using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
    public class Choices
    {
        [Key]
        public int ChoiceID { get; set; }
        public int QuestionID { get; set; }
        public string BeerChoice { get; set; }
		public string AnswerText { get; set; }
	}
}