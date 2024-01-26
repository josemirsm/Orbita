using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string? Fantasia { get; set; }
        public string? Razao { get; set; }
        public string? Cnpj { get; set; }
        public string? Iestadual { get; set; }
        public int? Ativo { get; set; }
        public int? Excluido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int IdEndereco { get; set; }
        public int IdContato { get; set; }
        public int IdEmpresa { get; set; }

        public virtual Contato IdContatoNavigation { get; set; } = null!;
        public virtual Endereco IdEnderecoNavigation { get; set; } = null!;
    }
}
