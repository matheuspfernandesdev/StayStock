namespace UI.Models
{
    public class DropDownViewModel : ViewModelBase
    {
        public string Nome { get; set; }

        public string IdString
        {
            get { return Identificador.ToString(); }
            set { }
        }
    }
}