using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Estoque
{
    public class CorViewModel : ViewModelBase
    {
        [Required(ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E001")]
        [MinLength(3, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        public string NomeCor { get; set; }

        [MinLength(7, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E002")]
        [MaxLength(20, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E003")]
        public string CodigoHex { get; set; }

        public string Descricao { get; set; }
    }
}
