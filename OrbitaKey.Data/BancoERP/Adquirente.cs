using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Adquirente
    {
        public int Id { get; set; }
        public int IdContato { get; set; }
        public int IdEndereco { get; set; }
        public int IdEmpresa { get; set; }
        public string Fantasia { get; set; }
        public string Razao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string IM { get; set; }
        public byte[] Logo { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual Endereco Endereco { get; set; }
    }
}
