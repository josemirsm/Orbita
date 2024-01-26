using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Metas
    {
        public int Id { get; set; }
        public int? CodProd { get; set; }
        public DateTime? Data { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Valor { get; set; }
        public int? CodigoVendedor { get; set; }
        public string Vendedor { get; set; }
        public int? CodigoGrupo { get; set; }
        public string Grupo { get; set; }
        public Enums.TipoMeta Tipo { get; set; }

    }
}
