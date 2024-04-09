using Dominio.Entities;
using System;

namespace UI.Models
{
    public class ViewModelBase : EntityBase
    {
        public const string MensagemErro = "O campo {0} é obrigatório";

        public bool EstaAtivo
        {
            get { return DataHoraExclusao == null ? true : false; }
            set { }
        }
        public string StatusAtivo
        {
            get { return DataHoraExclusao == null ? "ATIVO" : "INATIVO"; }
            set { }
        }
    }
}