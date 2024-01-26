using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Maquina
    {
        public int Idmaquina { get; set; }
        public string? Nome { get; set; }
        public string? Mac { get; set; }
        public string? Ip { get; set; }
        public DateTime? PrimeiroAcesso { get; set; }
        public string? UltimoAcesso { get; set; }
        public string? Sistema { get; set; }
        public string? Versao { get; set; }
        public string? Usuario { get; set; }
        public string? Cnpj { get; set; }
        public string? AnyDesk { get; set; }
        public string? AnyDeskSenha { get; set; }
        public string? TeamViewer { get; set; }
        public string? TeamViewerSenha { get; set; }
        public int? IdEmpresa { get; set; }
        public string? Chave { get; set; }
    }
}
