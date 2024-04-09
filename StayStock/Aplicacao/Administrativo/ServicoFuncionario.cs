using Dominio.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Administrativo
{
    public class ServicoFuncionario : ServicoBase<Funcionario>
    {
        public ServicoFuncionario()
        {

        }


        public List<Funcionario> ObterTodosAtivosPorFiltro(Expression<Func<Funcionario, bool>> filter = null,
                Func<IQueryable<Funcionario>, IOrderedQueryable<Funcionario>> orderBy = null,
                string includeProperties = "")
        {
            //TODO: Fazer incluir esse parametro Obter Por Filtros
            //filter = filter.And(x => x.DataHoraExclusao == null);

            return UOW.FuncionarioRepository.Get(filter, orderBy, includeProperties).ToList();
        }
    }
}
