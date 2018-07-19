using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
	public class BeerType
	{
		[Key]
		public int BeerTypeId { get; set; }
		public string Type { get; set; }
		public string YoutubeId { get; set; }
	}
}