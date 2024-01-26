using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class AuxCep
    {
        public int Id { get; set; }
        public string? Estado { get; set; }
        public string? Uf { get; set; }
        public string? Cidade { get; set; }
        public string? Bairro { get; set; }
        public string? Logradouro { get; set; }
        public string? Cep { get; set; }
        public string? CMun { get; set; }
        public int? CUf { get; set; }
    }
}
