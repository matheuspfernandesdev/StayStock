using System.Web.Mvc;

namespace UI.Controllers.Administrativo
{
    public class FinanceiraController : BaseController
    {
        // GET: Financeira
        public ActionResult Index()
        {
            return View();
        }

        // GET: Financeira/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Financeira/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Financeira/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Financeira/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Financeira/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Financeira/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Financeira/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
