using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Empresa
    {
        public int Id { get; set; }
        public string Cnpj { get; set; }
        public string Database { get; set; }
        public string Descricao { get; set; }
        public string Host { get; set; }
        public int? Porta { get; set; }
        public string Razao { get; set; }
        public string Senha { get; set; }
    }
}
