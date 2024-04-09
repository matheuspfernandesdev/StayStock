using Aplicacao.Estoque;
using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using Dominio.Framework;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Web.Mvc;
using UI.AutoMapper;
using UI.Models.Estoque;

namespace UI.Controllers.Estoque
{
    public class TipoProdutoController : BaseController
    {
        private readonly ServicoTipoProduto servicoTipoProduto;

        public TipoProdutoController()
        {
            servicoTipoProduto = new ServicoTipoProduto();
        }

        public ActionResult Index()
        {
            Expression<Func<TipoProduto, bool>> filter = ExpressionMaker.True<TipoProduto>();
            IEnumerable<TipoProdutoViewModel> model = new List<TipoProdutoViewModel>();

            //filter = filter.And(x => x.DataHoraExclusao == null);

            model = EntidadeParaViewModel.ListaTipoProduto(servicoTipoProduto.ObterTodosAtivosPorFiltro());

            //TODO: Colocar um OrderBy Nome 

            return View(model);
        }
        
        public ActionResult Details(int id)
        {
            return View();
        }
        
        public ActionResult Create()
        {
            TipoProdutoViewModel model = new TipoProdutoViewModel();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Create(TipoProdutoViewModel model)
        {
            string errosRetorno;
            TipoProduto tipoProduto;
            errosRetorno = ValidouCampos(model);

            if (string.IsNullOrEmpty(errosRetorno))
            {
                try
                {
                    tipoProduto = ViewModelParaEntidade.TipoProduto(model);

                    if (model.Identificador == 0)
                    {
                        servicoTipoProduto.Incluir(tipoProduto);
                        NotificacaoSucesso("Tipo Produto cadastrado com sucesso!");
                    }
                    else
                    {
                        servicoTipoProduto.Alterar(tipoProduto);
                        NotificacaoSucesso("Tipo Produto alterado com sucesso!");
                    }

                    return RedirectToAction("Index", "TipoProduto");
                }
                catch (ServiceException e)
                {
                    NotificacaoErro(e.Message);

                    return View(model);
                }
                catch (Exception e)
                {
                    NotificacaoErro("Erro ao cadastrar Tipo Produto. Consulte o Suporte! Erro: " + e.Message);

                    return View(model);
                }
            }
            else
            {
                NotificacaoAviso(errosRetorno);
                return View(model);
            }
        }
        
        public ActionResult Edit(int id)
        {
            TipoProdutoViewModel model = EntidadeParaViewModel.TipoProduto(servicoTipoProduto.ObterPorId(id));

            return View(model);
        }

        private string ValidouCampos(TipoProdutoViewModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ValidateViewModel(model));

            return sb.ToString();
        }
    }
}
