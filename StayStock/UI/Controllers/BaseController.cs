using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace UI.Controllers
{
    public class BaseController : Controller
    {
        //TODO: Fazer o footer ficar na parte debaixo da tela

        public void DesbloquearBloquear(string Processando, string acao)
        {
            //Adiciona um cookie com o nome de hidden no html "Processando" 
            Response.Cookies.Add(new HttpCookie(Processando, acao));
        }

        public void NotificacaoSucesso(string mensagem)
        {
            TempData["MSG_S"] = mensagem;
        }

        public void NotificacaoErro(string mensagem)
        {
            ViewData["MSG_E"] = mensagem;
        }

        public void NotificacaoAviso(string mensagem)
        {
            ViewData["MSG_A"] = mensagem;
        }

        public string ValidateViewModel(object model)
        {
            StringBuilder sb = new StringBuilder();

            var listaMensagens = new List<ValidationResult>();
            var contexto = new ValidationContext(model);
            bool isValid = Validator.TryValidateObject(model, contexto, listaMensagens, true);

            if (!isValid)
            {
                foreach (var mensagem in listaMensagens)
                {
                    sb.Append(mensagem.ErrorMessage + "<br/> ");
                }
            }

            return sb.ToString();
        }

        public static string RenderPartialToString(string controlName, object viewData)
        {
            ViewPage viewPage = new ViewPage() { ViewContext = new ViewContext() };

            viewPage.ViewData = new ViewDataDictionary(viewData);
            viewPage.Controls.Add(viewPage.LoadControl(controlName));

            StringBuilder sb = new StringBuilder();
            using (StringWriter sw = new StringWriter(sb))
            {
                using (HtmlTextWriter tw = new HtmlTextWriter(sw))
                {
                    viewPage.RenderControl(tw);
                }
            }

            return sb.ToString();
        }

        protected string ConvertViewToString(string viewName, object model)
        {
            ViewData.Model = model;
            using (StringWriter writer = new StringWriter())
            {
                ViewEngineResult vResult = ViewEngines.Engines.FindPartialView(ControllerContext, viewName);
                ViewContext vContext = new ViewContext(this.ControllerContext, vResult.View, ViewData, new TempDataDictionary(), writer);
                vResult.View.Render(vContext, writer);
                return writer.ToString();
            }
        }
    }
}
