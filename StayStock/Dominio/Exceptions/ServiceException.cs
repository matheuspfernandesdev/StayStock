using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Exceptions
{
    public class ServiceException : Exception
    {
        public ServiceException()
        {

        }

        public ServiceException(string name)
            : base(String.Format("Erro Encontrado: {0}", name))
        {

        }
    }
}
