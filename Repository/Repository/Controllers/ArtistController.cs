using Repository.Models;
using Repository.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class ArtistController : Controller
    {

        ArtistRepository repository = new ArtistRepository();

        // GET: Artist
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Details(int id)
        {
            Artist artist = repository.Get(id);
            if (artist == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(artist);
            }

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Artist artist)
        {
            if (!ModelState.IsValid) return View();
            repository.Add(artist);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}