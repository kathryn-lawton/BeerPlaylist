using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
    public class Choices
    {
        [Key]
        public int ChoiceID { get; set; }
        public int QuestionID { get; set; }
		public string AnswerText { get; set; }
		[ForeignKey("BeerType")]
		public int BeerTypeId { get; set; }
		public BeerType BeerType { get; set; }


	}
}