using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComicsApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComicsApp.Controllers
{
    public class ComicController : Controller
    {
        public IActionResult Index()
        {
            List<Comic> comics = new List<Comic>();

            comics.Add(new Comic
            {
                DateRelease = DateTime.Now,
                Id = 1,
                Name = "Spiderman",
                Price = 123
            });

            comics.Add(new Comic
            {
                DateRelease = new DateTime(1999, 12, 12),
                Id = 2,
                Name = "Captain America",
                Price = 323
            });

            comics.Add(new Comic
            {
                DateRelease = new DateTime(2012, 06, 14),
                Id = 3,
                Name = "Ironman",
                Price = 2323
            });

            return View(comics);
        }
    }
}