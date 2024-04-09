using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Administrativo
{
    public class FabricaViewModel : ViewModelBase
    {
        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(2, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        public string Nome { get; set; }

        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(18, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E005")]
        public string CNPJ { get; set; }

        public int EnderecoIdentificador { get; set; }
        public EnderecoViewModel EnderecoViewModel { get; set; }

        [EmailAddress(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E004")]
        public string Email { get; set; }

        public string Descricao { get; set; }
        public string Telefone { get; set; }
    }
}