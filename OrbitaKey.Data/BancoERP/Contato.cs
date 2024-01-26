using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Contato
    {
        public Contato()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
            Fornecedor = new HashSet<Fornecedor>();
            Funcionario = new HashSet<Funcionario>();
        }

        public int Idcontato { get; set; }
        public string Celular { get; set; }
        public string Celular2 { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public int? Excluido { get; set; }
        public string NomeRepresentante { get; set; }
        public string Ramal { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string TelefoneRepresentante { get; set; }
        public virtual ICollection<Estabelecimento> Estabelecimento { get; set; }
        public virtual ICollection<Fornecedor> Fornecedor { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
