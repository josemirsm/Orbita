using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Endereco
    {
        public Endereco()
        {
            Estabelecimento = new HashSet<Estabelecimento>();
            Fornecedor = new HashSet<Fornecedor>();
            Funcionario = new HashSet<Funcionario>();
        }

        public int Idendereco { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string CodigoMunicipio { get; set; }
        public string Complemento { get; set; }
        public DateTime? DataCadastro { get; set; }
        public bool Entrega { get; set; }
        public string Excluido { get; set; }
        public decimal? Latitude { get; set; }
        public string Logradouro { get; set; }
        public decimal? Longitude { get; set; }
        public string Numero { get; set; }
        public string Obs { get; set; }
        public string Uf { get; set; }

        public virtual ICollection<Estabelecimento> Estabelecimento { get; set; }
        public virtual ICollection<Fornecedor> Fornecedor { get; set; }
        public virtual ICollection<Funcionario> Funcionario { get; set; }
    }
}
