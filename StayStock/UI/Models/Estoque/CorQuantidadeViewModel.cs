using System.Collections.Generic;

namespace UI.Models.Estoque
{
    public class CorQuantidadeViewModel : ViewModelBase
    {
        public int? IdentificadorCor { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public string CodigoCor { get; set; }

        public List<DropDownViewModel> Cores { get; set; }
    }
}
