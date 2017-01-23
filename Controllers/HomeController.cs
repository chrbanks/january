using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using January.Data;
using Microsoft.AspNetCore.Mvc;

namespace January.Controllers
{
    public class HomeController : Controller
    {
        private ITopicRepository repo;

        public HomeController(ITopicRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var topic = repo.Get(1);
            return View(topic);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
