using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BeerPlaylist;

namespace BeerPlaylist.Models
{
    public class Forum
    {
        [Key]
        public int CommentId { get; set; }
		public DateTime Timestamp { get; set; }
		public string Comment { get; set; }

		[ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User{ get; set; }
    }
}