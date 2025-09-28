using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wu_Athena_EC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Wu_Athena_EC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Timeline()
        {
            var events = new List<Event>
            {
                new Event
                {
                    Title = "Birthday!",
                    Date = new DateTime(2004, 11, 6),
                    Description = "I was born.",
                    ImageUrl = "bday.jpg"
                },
                new Event
                {
                    Title = "Caught a Fish",
                    Date = new DateTime(2008, 8, 3),
                    Description = "I caught this fish all on my own...",
                    ImageUrl = "fish.jpg"
                },
                new Event
                {
                    Title = "Basketball",
                    Date = new DateTime(2017, 4, 23),
                    Description = "I played basketball and we were really good.",
                    ImageUrl = "bball.jpg"
                },
                new Event
                {
                    Title = "Re-Wunion",
                    Date = new DateTime(2018, 7, 15),
                    Description = "Family reunion in Canada. Ate lots of Chinese food.",
                    ImageUrl = "fam.jpg"
                },
                new Event
                {
                    Title = "Covid",
                    Date = new DateTime(2021, 2, 9),
                    Description = "In the depths of Covid. I dyed my hair red.",
                    ImageUrl = "red.jpeg"
                },
                new Event
                {
                    Title = "GRAD",
                    Date = new DateTime(2023, 5, 18),
                    Description = "Friend group survived high school (but not college).",
                    ImageUrl = "grad.jpeg"
                },
                new Event
                {
                    Title = "Austin, TX",
                    Date = new DateTime(2023, 8, 22),
                    Description = "First night out in Austin! #college",
                    ImageUrl = "austin.jpg"
                },
                new Event
                {
                    Title = "UT Game",
                    Date = new DateTime(2025, 9, 20),
                    Description = "First UT game... #HookEm",
                    ImageUrl = "hookem.jpg"
                }
            };

            return View(events);
        }

        public IActionResult Photography()
        {
            var photos = new List<Photo>
            {
                new Photo
                {
                    Title = "Santa Cruz, CA",
                    PhotoUrl = "beach.jpg"
                },
                new Photo
                {
                    Title = "Yellowstone National Park",
                    PhotoUrl = "yellowstone.jpg"
                },
                new Photo
                {
                    Title = "Cabo San Lucas, Mexico",
                    PhotoUrl = "cabo.jpeg"
                },
                new Photo
                {
                    Title = "Aptos, CA",
                    PhotoUrl = "aptos.jpg"
                },
                new Photo
                {
                    Title = "Checkmate",
                    PhotoUrl = "chess.jpeg"
                },
                new Photo
                {
                    Title = "Halloween Party",
                    PhotoUrl = "halloween.jpg"
                }
            };

            return View(photos);
        }
    }
}

