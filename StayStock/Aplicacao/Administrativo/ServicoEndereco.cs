using Dominio.Entities.Administrativo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacao.Administrativo
{
    public class ServicoEndereco : ServicoBase<Endereco>
    {
        public void Incluir(Endereco endereco)
        {
            UOW.EnderecoRepository.Insert(endereco);
            UOW.Save();
        }

        public void Alterar(Endereco enderecoAlterado)
        {
            Endereco enderecoOriginal = AtualizaEnderecoOriginal(enderecoAlterado);

            UOW.EnderecoRepository.Update(enderecoOriginal);
            UOW.Save();
        }

        private Endereco AtualizaEnderecoOriginal(Endereco enderecoAlterado)
        {
            Endereco enderecoOriginal = ObterPorId(enderecoAlterado.Identificador);

            enderecoOriginal.CEP = enderecoAlterado.CEP;
            enderecoOriginal.Municipio = enderecoAlterado.Municipio;
            enderecoOriginal.Bairro = enderecoAlterado.Bairro;
            enderecoOriginal.Rua = enderecoAlterado.Rua;
            enderecoOriginal.Numero = enderecoAlterado.Numero;

            return enderecoOriginal;
        }

        public Endereco ObterPorId(int id)
        {
            return UOW.EnderecoRepository.GetByID(id);
        }
    }
}
