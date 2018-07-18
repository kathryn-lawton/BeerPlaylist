using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeerPlaylist.Controllers
{
	public class HomeController : Controller
	{
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

		//[HttpGet]
		//public ActionResult Beers(string searching)
		//{
		//	List<Beer> beers = new List<Beer>();
		//	if (!string.IsNullOrEmpty(searching))
		//	{
		//		beers = db.Beer.Where(b => b.Name.Contains(searching)).ToList();
		//	}
		//	else
		//	{
		//		beers = db.Beer.ToList();
		//	}
		//	return View(beers.ToList());
		//}
	}
}