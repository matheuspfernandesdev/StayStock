using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using UI.Mensagens;
using UI.Models.Administrativo;

namespace UI.Models.Estoque
{
    public class ProdutoViewModel : ViewModelBase
    {
        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        public string NumeroSerie { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public decimal ValorVenda { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public int IdentificadorTipoProduto { get; set; }
        public TipoProdutoViewModel TipoProdutoViewModel { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public int IdentificadorFabrica { get; set; }
        public FabricaViewModel FabricaViewModel { get; set; }

        public ICollection<CorViewModel> ListaCor { get; set; }
    }
}