using System.Collections.Generic;
using System.Web.Mvc;
using UI.AutoMapper;
using UI.Models.Estoque;
using Aplicacao.Estoque;
using Aplicacao.Administrativo;
using System.Linq;
using UI.Models;
using System;

namespace UI.Controllers.Estoque
{
    public class EstoqueController : BaseController
    {
        private readonly ServicoProdutoEstoque servicoProdutoEstoque;
        private readonly ServicoCor servicoCor;
        private readonly ServicoProduto servicoProduto;
        private readonly ServicoProdutoCor servicoProdutoCor;
        private readonly ServicoFabrica servicoFabrica;
        private readonly ServicoTipoProduto servicoTipoProduto;

        public EstoqueController()
        {
            servicoProdutoEstoque = new ServicoProdutoEstoque();
            servicoProduto = new ServicoProduto();
            servicoProdutoCor = new ServicoProdutoCor();
            servicoFabrica = new ServicoFabrica();
            servicoTipoProduto = new ServicoTipoProduto();
            servicoCor = new ServicoCor();
        }

        public ActionResult Index()
        {
            IEnumerable<ListarEstoqueViewModel> model = new List<ListarEstoqueViewModel>();
            var listaProdutos = servicoProdutoCor.ObterTodosAtivosPorFiltro(null, null, "Cor,Produto,Produto.TipoProduto,Produto.Fabrica,ListaProdutosEmEstoque");

            model = EntidadeParaViewModel.ListaDeListarEstoque(listaProdutos);

            //TODO: Colocar um OrderBy Nome 
            return View(model);
        }

        public ActionResult Create()
        {
            EstoqueProdutoViewModel model = new EstoqueProdutoViewModel();

            //EXPRESSION MAKER NÃO FUNCIONA DESSA MANEIRA
            //Expression<Func<Fabrica, bool>> filter = ExpressionMaker.True<Fabrica>();
            //filter = filter.And(x => x.Identificador == 1);
            //filter.Compile();
            //var teste = servicoFabrica.ObterTodosAtivosPorFiltro(filter, null, "");

            model.Fabricas = servicoFabrica.ObterTodosAtivosPorFiltro()
                                           .Where(x => x.DataHoraExclusao == null)
                                           .OrderBy(x => x.Nome)
                                           .Select(x => new DropDownViewModel()
                                           {
                                               Identificador = x.Identificador,
                                               Nome = x.Nome,
                                           }).ToList();

            model.TiposProduto = servicoTipoProduto.ObterTodosAtivosPorFiltro()
                                                   .Where(x => x.DataHoraExclusao == null)
                                                   .OrderBy(x => x.Nome)
                                                   .Select(x => new DropDownViewModel()
                                                   {
                                                       Identificador = x.Identificador,
                                                       Nome = x.Nome,
                                                   }).ToList();

            return View(model);
        }

        public ActionResult CorQuantidade(CorQuantidadeViewModel model)
        {
            model.Cores = servicoCor.ObterTodosAtivosPorFiltro()
                                            .Where(x => x.DataHoraExclusao == null)
                                            .OrderBy(x => x.NomeCor)
                                            .Select(x => new DropDownViewModel()
                                            {
                                                Identificador = x.Identificador,
                                                Nome = x.NomeCor,
                                            }).ToList();

            return PartialView("_CorQuantidade", model);
        }

        public string NovaCorQuantidade()
        {
            CorQuantidadeViewModel modelCor = new CorQuantidadeViewModel();

            modelCor.Cores = servicoCor.ObterTodosAtivosPorFiltro()
                                            .Where(x => x.DataHoraExclusao == null)
                                            .OrderBy(x => x.NomeCor)
                                            .Select(x => new DropDownViewModel()
                                            {
                                                Identificador = x.Identificador,
                                                Nome = x.NomeCor,
                                            }).ToList();

            //string model = RenderPartialToString("_CorQuantidade", modelCor);
            string model = ConvertViewToString("_CorQuantidade", modelCor);
            //return Json(new { model = Url.Action("RetornaPartialViewTrTable", modelCores) });
            //return Json(model, JsonRequestBehavior.AllowGet);
            //return PartialView("_CorQuantidade", model);


            //return Json(model, JsonRequestBehavior.AllowGet);
            //return model.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            return model;
        }
        public ActionResult RetornaPartialViewTrTable(CorQuantidadeViewModel model)
        {
            return PartialView("_CorQuantidade", model);
        }

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

        public ActionResult Edit(int id)
        {
            EstoqueProdutoViewModel model = new EstoqueProdutoViewModel();
            model = EntidadeParaViewModel.EstoqueProduto(servicoProdutoCor.ObterPorIdEagerLoading(id));

            model.Fabricas = servicoFabrica.ObterTodosAtivosPorFiltro()
                               .Where(x => x.DataHoraExclusao == null)
                               .OrderBy(x => x.Nome)
                               .Select(x => new DropDownViewModel()
                               {
                                   Identificador = x.Identificador,
                                   Nome = x.Nome,
                               }).ToList();

            model.TiposProduto = servicoTipoProduto.ObterTodosAtivosPorFiltro()
                                                   .Where(x => x.DataHoraExclusao == null)
                                                   .OrderBy(x => x.Nome)
                                                   .Select(x => new DropDownViewModel()
                                                   {
                                                       Identificador = x.Identificador,
                                                       Nome = x.Nome,
                                                   }).ToList();

            return View(model);
        }

        public ActionResult ObterCores(string qtdProdutoEstoque)
        {
            List<DropDownViewModel> listaDropDownCores = new List<DropDownViewModel>();

            string model = "";

            try
            {
                model += "<select class=\"dropCores form-control\"" + "id=\"corQtd" + qtdProdutoEstoque +"\"" +"> <option value=\"0\" selected>Selecione...</option>";
                //model += "<select class=\"dropCores" + qtdProdutoEstoque + "form-control\"> <option value=\"0\" selected>Selecione...</option>";

                listaDropDownCores = servicoCor.ObterTodosAtivosPorFiltro()
                                                    .Where(x => x.DataHoraExclusao == null)
                                                    .OrderBy(x => x.NomeCor)
                                                    .Select(x => new DropDownViewModel()
                                                    {
                                                        Identificador = x.Identificador,
                                                        Nome = x.NomeCor,
                                                    }).ToList();

                if (listaDropDownCores != null)
                {
                    foreach (var item in listaDropDownCores)
                    {
                        model += "<option value=" + item.Identificador + ">" + item.Nome + "</option>";
                    }
                }

                model += "</select>";
            }
            catch (Exception)
            {

            }

            return Json(model, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ObterCodigoCor(string id)
        {
            string model = "";

            try
            {
                var Id = Convert.ToInt32(id);
                model = servicoCor.ObterPorId(Id).CodigoCor;
            }
            catch (Exception)
            {

            }

            return Json(model, JsonRequestBehavior.AllowGet);
        }

    }
}
