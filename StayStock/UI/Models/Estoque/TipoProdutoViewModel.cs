using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Estoque
{
    public class TipoProdutoViewModel : ViewModelBase
    {
        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        public string Descricao { get; set; }
    }
}