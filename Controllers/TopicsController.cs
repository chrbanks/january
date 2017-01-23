using January.Data;
using January.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace January.Controllers
{
    public class TopicsController : Controller
    {
        private readonly ITopicRepository repo;

        public TopicsController(ITopicRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var topics = repo.GetAll();
            return View(topics);
        }

        public IActionResult Details(int id)
        {
            var topic = repo.Get(id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        public IActionResult New()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title")] Topic topic)
        {
            try
            {
                repo.Add(topic);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(topic);
        }

        public IActionResult Edit(int id)
        {
            var topic = repo.Get(id);
            if (topic == null)
            {
                return NotFound();
            }
            return View(topic);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Topic topic)
        {
            try
            {
                repo.Update(topic);
                return RedirectToAction("Index");
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(topic);
        }

        public IActionResult Delete(int id)
        {
            var topic = repo.Get(id);
            if (topic == null)
            {
                return NotFound();
            }

            repo.Delete(topic);
            return RedirectToAction("Index");
        }
    }
}