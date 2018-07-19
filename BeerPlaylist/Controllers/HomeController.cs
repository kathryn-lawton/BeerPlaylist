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

		[HttpPost]
		public ActionResult Survey(SurveyViewModel model)
		{
			int beerAverage = 0;
			foreach (var question in model.questions)
			{
				var choice = db.Choices.Where(c => c.AnswerText == question.Answer).Select(c => c).FirstOrDefault();
				beerAverage += choice.BeerTypeId;
			}

			beerAverage /= model.questions.Count;

			return RedirectToAction("SurveyResults", new { id = beerAverage});
		}

		[HttpGet]
		public ActionResult SurveyResults(int? id)
		{
			if (id == null)
			{
				return HttpNotFound();
			}

			var model = new SurveyResultsViewModel();
			model.BeerType = db.BeerType.Where(b => b.BeerTypeId == id).FirstOrDefault();
			model.Beers = db.Beer.Where(b => b.BeerTypeId == id).ToList();

			return View(model);
		}
	}
}