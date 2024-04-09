using System.ComponentModel.DataAnnotations;

namespace Dominio.Entities.Administrativo
{
    public class Financeira : EntityBase
    {
        //public int Identificador { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Descricao { get; set; }
    }
}
