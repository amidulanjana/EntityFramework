using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class ArtistController : Controller
    {

        MusicStoreDataContext context = new MusicStoreDataContext();

        // GET: Artist
        public ActionResult Index()
        {
            return View(context.Artists.ToList());
        }
    }
}