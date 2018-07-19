using BeerPlaylist.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeerPlaylist.ViewModels
{
	public class SurveyResultsViewModel
	{
		public BeerType BeerType { get; set; }
		public List<Beer> Beers { get; set; }
	}
}