using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BeerPlaylist.Models
{
	public class Beer
	{
		[Key]
		public int BeerId { get; set; }
		public string Name { get; set; }
		public string ABV { get; set; }
		public string City { get; set; }
		public string Price { get; set; }
		[ForeignKey("BeerType")]
		public int BeerTypeId { get; set; }
		public BeerType BeerType { get; set; }
	}
}