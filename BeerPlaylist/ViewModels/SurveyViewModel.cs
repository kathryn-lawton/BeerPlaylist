using BeerPlaylist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPlaylist.ViewModels
{
	public class SurveyViewModel
	{
		public List<Questions> questions { get; set; }
		public List<Choices> choices { get; set; }
	}
}