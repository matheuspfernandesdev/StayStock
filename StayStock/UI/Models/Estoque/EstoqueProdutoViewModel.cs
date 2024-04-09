using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Estoque
{
    public class EstoqueProdutoViewModel : ViewModelBase
    {
        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        public string NomeProduto { get; set; }

        public string NumeroSerie { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public string ValorVenda { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public int IdentificadorTipoProduto { get; set; }

        public List<DropDownViewModel> TiposProduto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public int IdentificadorFabrica { get; set; }

        public List<DropDownViewModel> Fabricas { get; set; }

        //public List<DropDownViewModel> Cores { get; set; }

        public List<CorQuantidadeViewModel> ListaCorQuantidade { get; set; }

        public EstoqueProdutoViewModel()
        {
            ListaCorQuantidade = new List<CorQuantidadeViewModel>();
        }
    }
}
