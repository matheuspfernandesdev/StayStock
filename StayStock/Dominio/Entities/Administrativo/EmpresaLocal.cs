namespace Dominio.Entities.Administrativo
{
    public class EmpresaLocal : EntityBase
    {
        //public int Identificador { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CNPJ { get; set; }
        public int EnderecoIdentificador { get; set; }
        public Endereco Endereco { get; set; }
        public int IdentificadorFuncionarioGestor { get; set; }
        public virtual Funcionario FuncionarioGestor { get; set; }
    }
}
