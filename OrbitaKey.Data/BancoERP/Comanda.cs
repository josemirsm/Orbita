using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Comanda
    {
        public int Id { get; set; }
        public DateTime? Abertura { get; set; }
        public bool? Cache { get; set; }
        public DateTime? Encerramento { get; set; }
        public bool? Finalizada { get; set; }
        public int? Mesa { get; set; }
        public string Obs { get; set; }
        public bool? Pago { get; set; }
        public bool Impresso { get; set; }
        public string EncerramentoPessoa { get; set; }
        public int IdVendedor { get; set; }
        public int IdUsuario { get; set; }
        public int Pessoas { get; set; }
        public decimal Couvert { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public bool Cancelada { get; set; }
        public string CanceladaPor { get; set; }
        public DateTime? Cancelamento { get; set; }
    }
}
