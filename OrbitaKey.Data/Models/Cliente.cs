using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public int? Codigo { get; set; }
        public string? Fantasia { get; set; }
        public string? Razao { get; set; }
        public string? Cnpj { get; set; }
        public string? Iestadual { get; set; }
        public bool? Ativo { get; set; }
        public bool? Excluido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Regime { get; set; }
        public int? IdContato { get; set; }
        public int? IdEndereco { get; set; }
        public int IdEmpresa { get; set; }
        public string? Observacao { get; set; }
        public string? Responsavel { get; set; }
        public decimal? TaxaInstalacao { get; set; }
        public decimal? Mensalidade { get; set; }
        public decimal MensalidadePercentual { get; set; }
        public int MensalidadeDiaVencimento { get; set; }
        public string? Preposto { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public DateOnly? DataInstalacao { get; set; }
        public int? ContratoAssinado { get; set; }
        public DateTime? Atualizacao { get; set; }
        public int? IdUsuario { get; set; }
    }
}
