using BeerPlaylist.Models;
using BeerPlaylist.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerPlaylist.Controllers
{
	public class HomeController : Controller
	{
		ApplicationDbContext db = new ApplicationDbContext();
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}


		[HttpGet]
		public ActionResult Beers(string searching)
		{
			List<Beer> beers = new List<Beer>();
			if (!string.IsNullOrEmpty(searching))
			{
				beers = db.Beer.Where(
					b => b.Name.Contains(searching) 
					|| b.BeerType.Type.Contains(searching) 
					|| b.City.Contains(searching) 
					|| b.ABV.Contains(searching) 
					|| b.Price.Contains(searching)).Include(b => b.BeerType).ToList();
			}
			else
			{
				beers = db.Beer.Include(b => b.BeerType).ToList();
			}
			return View(beers.ToList());
		}

		[HttpGet]
		public ActionResult Survey()
		{
			var model = new SurveyViewModel();
			model.questions = db.Questions.ToList();
			model.choices = db.Choices.ToList();

			return View(model);
		}
	}
}