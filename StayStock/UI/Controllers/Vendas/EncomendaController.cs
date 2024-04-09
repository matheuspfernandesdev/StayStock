using System.Web.Mvc;

namespace UI.Controllers.Vendas
{
    public class EncomendaController : BaseController
    {
        // GET: Encomenda
        public ActionResult Index()
        {
            return View();
        }

        // GET: Encomenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Encomenda/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Encomenda/Create
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

        // GET: Encomenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Encomenda/Edit/5
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

        // GET: Encomenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Encomenda/Delete/5
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
