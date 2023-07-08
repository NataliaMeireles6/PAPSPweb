using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PAPSPweb.Controllers
{
    public class SobrenosController : Controller
    {
        // GET: SobrenosController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SobrenosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SobrenosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SobrenosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SobrenosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SobrenosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SobrenosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SobrenosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
