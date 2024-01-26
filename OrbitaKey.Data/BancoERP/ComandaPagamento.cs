using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ComandaPagamento
    {
        public int Id { get; set; }
        public int IdComanda { get; set; }
        public int IdTipoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public DateTime Data { get; set; }        
        public bool Impresso { get; set; }
        public decimal Valor { get; set; }
        public string Cliente { get; set; }
        public string Obs { get; set; }
        public int IdVendedor { get; set; }
        public int IdUsuario { get; set; }
        public int IdVendedorCancelamento { get; set; }
        public int IdUsuarioCancelamento { get; set; }
        public bool Cancelado { get; set; }
        public DateTime? DataCancelamento { get; set; }
    }
}
