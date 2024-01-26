using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Suporte
    {
        public int Idsuporte { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdCliente { get; set; }
        public int? IdColaborador { get; set; }
        public string? Telefone { get; set; }
        public string? Celular { get; set; }
        public string? Celular2 { get; set; }
        public string? Setor { get; set; }
        public string? Tipo { get; set; }
        public string? Prioridade { get; set; }
        public DateTime? HoraMarcada { get; set; }
        public string? FormaAtendimento { get; set; }
        public string? Solicitante { get; set; }
        public string? CodigoAcesso { get; set; }
        public string? Descricao { get; set; }
        public string? Detalhamento { get; set; }
        public DateTime? DataCriacao { get; set; }
        public int? Iniciado { get; set; }
        public int? Finalizado { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        public DateTime? InicioAtendimento { get; set; }
        public string? SenhaAcesso { get; set; }
    }
}
