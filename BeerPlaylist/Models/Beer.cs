using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
	public class Beer
	{
		[Key]
		public int BeerId { get; set; }
		public string Name { get; set; }
		public string Type { get; set; }
		public double ABV { get; set; }
		public string City { get; set; }
		public double Price { get; set; }
	}
}