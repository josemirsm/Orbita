using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Licenca
    {
        public int Id { get; set; }
        public int? CodigoLicenca { get; set; }
        public int? IdEmpresa { get; set; }
        public uint? IdCliente { get; set; }
        public DateOnly? DataAtivacao { get; set; }
        public DateTime? DataCriacao { get; set; }
        public int? BloqueioAutomatico { get; set; }
        public int? BloqueioManual { get; set; }
        public sbyte? BloqueioAdm { get; set; }
        public sbyte? BloqueioPdv { get; set; }
        public string? MotivoBloqueio { get; set; }
        public DateOnly? DataVencimento { get; set; }
        public sbyte? Ativa { get; set; }
        public sbyte? Pdv { get; set; }
        public sbyte? Financeiro { get; set; }
        public sbyte? Nfe { get; set; }
        public sbyte? RelatorioVendas { get; set; }
        public sbyte? RemessaMes { get; set; }
        public string? Chave { get; set; }
        public DateOnly? DataDesativacao { get; set; }
        public int? IdUsuarioAtivacao { get; set; }
        public int? IdUsuarioDesativacao { get; set; }
        public sbyte? Temporaria { get; set; }
        public int? UsuarioBloqueio { get; set; }
        public DateTime? DataBloqueio { get; set; }
        public int? Plano { get; set; }
        public int? Comanda { get; set; }
        public int? VendaExterna { get; set; }
        public int? Maquinas { get; set; }
        public sbyte? Os { get; set; }
        public sbyte? Nfce { get; set; }
        public sbyte? RelatorioEntradas { get; set; }
    }
}
