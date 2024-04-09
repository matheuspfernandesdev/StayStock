using System.ComponentModel.DataAnnotations;
using UI.Mensagens;

namespace UI.Models.Administrativo
{
    public class EnderecoViewModel : ViewModelBase
    {
        public string Bairro { get; set; }
        public string Rua { get; set; }

        [Display(Name = "Número")]
        [MaxLength(10, ErrorMessageResourceType = typeof(Notificacao), ErrorMessageResourceName = "MSG_E003")]
        public string Numero { get; set; }                 
        public string CEP { get; set; }

        [Display(Name = "Município")]
        public string Municipio { get; set; }
        public string Telefone { get; set; }
    }
}