using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Empresa
    {
        public int IdEmpresa { get; set; }
        public int IdEndereco { get; set; }
        public int IdContato { get; set; }
        public string? Fantasia { get; set; }
        public string? Razao { get; set; }
        public string? Iestadual { get; set; }
        public string? Cnpj { get; set; }
        public int? Ativo { get; set; }
        public int? Excluido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Responsavel { get; set; }
        public string? Observacao { get; set; }
        public byte[]? LogoAdm { get; set; }
        public byte[]? LogoPdv { get; set; }
        public byte[]? FundoAdm { get; set; }
        public string? Cor1 { get; set; }
        public string? Cor2 { get; set; }
        public string? Cor3 { get; set; }
        public string? SchemaPadrao { get; set; }
        public string? SenhaPadrao { get; set; }
    }
}
