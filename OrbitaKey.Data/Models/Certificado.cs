using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Certificado
    {
        public int Id { get; set; }
        public string? Cnpj { get; set; }
        public byte[]? Certificado1 { get; set; }
        public DateTime? Vencimento { get; set; }
        public DateTime? Emissao { get; set; }
        public int? IdEmpresa { get; set; }
        public string? Chave { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Razao { get; set; }
        public string? Senha { get; set; }
    }
}
