using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class AuxCep
    {
        public int Id { get; set; }
        public string Bairro { get; set; }
        public int? CMun { get; set; }
        public int? CUf { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Uf { get; set; }
    }
}
