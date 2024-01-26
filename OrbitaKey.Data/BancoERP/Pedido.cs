using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Pedido
    {
        public int Id { get; set; }
        public bool? Aprovado { get; set; }
        public int? CdCliente { get; set; }
        public int? CdUsuario { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataRecebimento { get; set; }
        public bool? EmAnalise { get; set; }
        public bool? EmTransporte { get; set; }
        public bool? Entregue { get; set; }
        public string IdDispositivo { get; set; }
        public int? IdMobile { get; set; }
        public string Obs { get; set; }
        public bool? Recebido { get; set; }
        public bool? Recusado { get; set; }
        public decimal? Valor { get; set; }
        public bool Reenviar { get; set; }
        public bool NFe { get; set; }
        public bool NFCe { get; set; }
        public string VersaoApp { get; set; }
        public string Guid { get; set; }
    }
}
