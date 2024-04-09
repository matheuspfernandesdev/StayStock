using System;

namespace Dominio.Entities
{
    public abstract class EntityBase
    {
        public int Identificador { get; set; }

        public virtual DateTime DataHoraInclusao { get; set; }

        public virtual DateTime DataHoraUltimaAlteracao { get; set; }

        public virtual DateTime? DataHoraExclusao { get; set; }
    }
}
