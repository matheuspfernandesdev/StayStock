using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Estoque
{
    public class ProdutoCorViewModel : ViewModelBase
    {
        public int? IdentificadorCor { get; set; }
        public CorViewModel CorViewModel { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        public int IdentificadorProduto { get; set; }
        public ProdutoViewModel ProdutoViewModel { get; set; }

        public string Descricao { get; set; }
    }
}