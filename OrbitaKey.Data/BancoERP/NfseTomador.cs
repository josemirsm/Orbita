using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NfseTomador
    {
        public int Id { get; set; }
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public int? CodigoCliente { get; set; }
        public int? CodigoMunicipio { get; set; }
        public string Complemento { get; set; }
        public string CpfCnpj { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Fantasia { get; set; }
        public int IdNota { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Razao { get; set; }
        public string RgIe { get; set; }
        public string Telefone { get; set; }
        public string Telefone2 { get; set; }
        public string Uf { get; set; }

        public virtual Nfse IdNotaNavigation { get; set; }
    }
}
