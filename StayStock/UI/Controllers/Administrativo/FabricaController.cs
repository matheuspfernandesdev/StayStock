using Dominio.Entities.Administrativo;
using System;
using System.Web.Mvc;
using UI.Models.Administrativo;
using System.Collections.Generic;
using System.Text;
using Dominio.Exceptions;
using Aplicacao.Administrativo;
using UI.AutoMapper;
using Dominio.Framework;
using System.Linq.Expressions;

namespace UI.Controllers.Administrativo
{
    public class FabricaController : BaseController
    {
        private readonly ServicoFabrica servicoFabrica;

        public FabricaController()
        {
            servicoFabrica = new ServicoFabrica();
        }
        
        public ActionResult Index()
        {
            Expression<Func<Fabrica, bool>> filter = ExpressionMaker.True<Fabrica>();
            IEnumerable<FabricaViewModel> model = new List<FabricaViewModel>();
        
            model = EntidadeParaViewModel.ListaFabrica(servicoFabrica.ObterTodosAtivosPorFiltro(x => x.DataHoraExclusao == null));

            //TODO: Colocar um OrderBy Nome 
            //TODO: Ideia >> Colocar um link em toda tabela que tenha o nome da Fabrica, redirecionando para o catalogo online da empresa

            return View(model);
        }
    
        public ActionResult Create()
        {
            FabricaViewModel model = new FabricaViewModel();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Create(FabricaViewModel model)
        {
            string errosRetorno;
            Fabrica fabrica;
            errosRetorno = ValidouCampos(model);

            if (string.IsNullOrEmpty(errosRetorno))
            {
                try
                {
                    fabrica = ViewModelParaEntidade.Fabrica(model);

                    if (model.Identificador == 0)
                    {
                        servicoFabrica.Incluir(fabrica);
                        NotificacaoSucesso("Fábrica cadastrada com sucesso!");
                    }
                    else
                    {
                        servicoFabrica.Alterar(fabrica);
                        NotificacaoSucesso("Fábrica alterada com sucesso!");
                    }

                    return RedirectToAction("Index", "Fabrica");
                }
                catch (ServiceException e)
                {
                    NotificacaoErro(e.Message);

                    return View(model);
                }
                catch (Exception e)
                {
                    NotificacaoErro("Erro ao cadastrar fábrica. Consulte o Suporte! Erro: " + e.Message);

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
            FabricaViewModel model = EntidadeParaViewModel.Fabrica(servicoFabrica.ObterPorIdComEndereco(id));

            return View(model);
        }

        private string ValidouCampos(FabricaViewModel model)
        {
            StringBuilder sb = new StringBuilder();
         
            sb.Append(ValidateViewModel(model));

            //Se preencheu algum dado de endereço da empresa...
            if (!string.IsNullOrEmpty(model.EnderecoViewModel.CEP) || !string.IsNullOrEmpty(model.EnderecoViewModel.Municipio) ||
                !string.IsNullOrEmpty(model.EnderecoViewModel.Bairro) || !string.IsNullOrEmpty(model.EnderecoViewModel.Rua) ||
                !string.IsNullOrEmpty(model.EnderecoViewModel.Numero))
            {
                if(model.EnderecoViewModel.CEP.Length < 9)
                {
                    sb.Append("O campo CEP não foi preenchido corretamente. " + "<br/> ");
                }

                //...mas não preencheu todos, dá erro
                if (string.IsNullOrEmpty(model.EnderecoViewModel.CEP) || string.IsNullOrEmpty(model.EnderecoViewModel.Municipio) ||
                   string.IsNullOrEmpty(model.EnderecoViewModel.Bairro) || string.IsNullOrEmpty(model.EnderecoViewModel.Rua) ||
                   string.IsNullOrEmpty(model.EnderecoViewModel.Numero))
                {
                    sb.Append("Favor preencher todos os campos do endereço.");
                }
            }

            return sb.ToString();
        }
    }
}
