using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Funcionario
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public int? Ativo { get; set; }
        public string Cpf { get; set; }
        public decimal? CreditoLimite { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataNascimento { get; set; }
        public byte[] Foto { get; set; }
        public int IdContato { get; set; }
        public int IdEndereco { get; set; }
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public string Rg { get; set; }

        public virtual Contato IdContatoNavigation { get; set; }
        public virtual Endereco IdEnderecoNavigation { get; set; }
    }
}
