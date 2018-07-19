using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeerPlaylist.Models;
using Microsoft.AspNet.Identity;

namespace BeerPlaylist.Controllers
{
    
    public class ForumController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Forum
        public ActionResult Index()
        {
            return View(db.Forum.Include(f => f.User).ToList());
        }

        // GET: Forum/Details/5
        public ActionResult Details(int? id)
        {
			if(id == null)
			{
				return HttpNotFound();
			}

			var model = db.Forum.Where(f => f.CommentId == id).Include(f => f.User).FirstOrDefault();

            return View(model);
        }

        // GET: Forum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        [HttpPost]
        public ActionResult Create(Forum model)
        {
			model.UserId = User.Identity.GetUserId();
			model.Timestamp = DateTime.Now;
			db.Forum.Add(model);
			db.SaveChanges();

			return RedirectToAction("Details", new { id = model.CommentId });
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int? id)
        {
			if(id != null)
			{
				var forum = db.Forum.Where(f => f.CommentId == id).FirstOrDefault();

				if(forum != null)
				{
					// TODO: Check if admin
					db.Forum.Remove(forum);
					db.SaveChanges();
				}
			}

            return RedirectToAction("Index");
        }
    }
}
