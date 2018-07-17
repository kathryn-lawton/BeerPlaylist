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
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual ApplicationUser User{ get; set; }
        public DateTime Timestamp { get; set; } 
        public string Comment { get; set; }
        [Display(Name ="Number of Comments")]
        public int CommentCount { get; set; }

    }
}