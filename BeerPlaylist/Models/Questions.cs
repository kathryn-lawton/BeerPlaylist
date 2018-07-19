using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeerPlaylist.Models
{
	public class Questions
    {
        [Key]
        public int QuestionID { get; set; }
        public string QuestionText { get; set; }
		[NotMapped]
		public string Answer { get; set; }
	}
}