using Aplicacao.Administrativo;
using Dominio.Entities.Administrativo;
using System.Collections.Generic;
using System.Web.Mvc;
using UI.AutoMapper;
using UI.Models.Administrativo;

namespace UI.Controllers.Administrativo
{
    public class FuncionarioController : BaseController
    {
        private readonly ServicoFuncionario servicoFuncionario;

        public FuncionarioController()
        {
            servicoFuncionario = new ServicoFuncionario();
        }

        // GET: Funcionario
        public ActionResult Index()
        {
            IEnumerable<Funcionario> model = new List<Funcionario>();
            model = servicoFuncionario.ObterTodosAtivosPorFiltro();

            //TODO: Colocar um OrderBy Nome 
            return View(model);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Funcionario/Create
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

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Funcionario/Edit/5
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

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Funcionario/Delete/5
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
