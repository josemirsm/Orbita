using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public int? Ativo { get; set; }
        public int? Codigo { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int? Excluido { get; set; }
        public int Idcontato { get; set; }
        public int Idendereco { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeOuRazao { get; set; }
        public string Observacao { get; set; }
        public string Regime { get; set; }
        public string RgIe { get; set; }
        public string TipoPessoa { get; set; }
        public virtual Contato IdcontatoNavigation { get; set; }
        public virtual Endereco IdenderecoNavigation { get; set; }
    }
}
