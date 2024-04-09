using Aplicacao.Estoque;
using Dominio.Entities.Estoque;
using Dominio.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using UI.AutoMapper;
using UI.Models.Estoque;

namespace UI.Controllers.Estoque
{
    public class CorController : BaseController
    {
        private readonly ServicoCor servicoCor;

        public CorController()
        {
            servicoCor = new ServicoCor();
        }
        
        public ActionResult Index()
        {
            IEnumerable<CorViewModel> model = new List<CorViewModel>();
            model = EntidadeParaViewModel.ListaCor(servicoCor.ObterTodosAtivosPorFiltro());

            //TODO: Colocar um OrderBy Nome 
            return View(model);
        }
        
        public ActionResult Create()
        {
            CorViewModel model = new CorViewModel();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Create(CorViewModel model)
        {
            string errosRetorno;
            Cor cor;
            errosRetorno = ValidouCampos(model);

            if (string.IsNullOrEmpty(errosRetorno))
            {
                try
                {
                    cor = ViewModelParaEntidade.Cor(model);

                    if (model.Identificador == 0)
                    {
                        servicoCor.Incluir(cor);
                        NotificacaoSucesso("Cor cadastrada com sucesso!");
                    }
                    else
                    {
                        servicoCor.Alterar(cor);
                        NotificacaoSucesso("Cor alterada com sucesso!");
                    }

                    return RedirectToAction("Index", "Cor");
                }
                catch (ServiceException e)
                {
                    NotificacaoErro(e.Message);

                    return View(model);
                }
                catch (Exception e)
                {
                    NotificacaoErro("Erro ao cadastrar cor. Consulte o Suporte! Erro: " + e.Message);

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
            CorViewModel model = EntidadeParaViewModel.Cor(servicoCor.ObterPorId(id));

            return View(model);
        }

        private string ValidouCampos(CorViewModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ValidateViewModel(model));

            return sb.ToString();
        }
    }
}
