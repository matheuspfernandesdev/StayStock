using System.Web.Mvc;

namespace UI.Controllers.Vendas
{
    public class PromissoriaController : BaseController
    {
        // GET: Promissoria
        public ActionResult Index()
        {
            return View();
        }

        // GET: Promissoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Promissoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Promissoria/Create
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

        // GET: Promissoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Promissoria/Edit/5
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

        // GET: Promissoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Promissoria/Delete/5
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
