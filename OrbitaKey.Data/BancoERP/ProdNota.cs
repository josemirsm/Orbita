using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ProdNota
    {
        public ProdNota()
        {
            ProdNotaprodutos = new HashSet<ProdNotaprodutos>();
        }

        public int IdprodNota { get; set; }
        public int? Cancelada { get; set; }
        public int? CodigoUsuario { get; set; }
        public decimal? CustoTotal { get; set; }
        public DateTime? DataLancamento { get; set; }
        public int? Excluida { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Liberada { get; set; }
        public string NomeUsuario { get; set; }
        public int? IdPreproducao { get; set; }

        public virtual ICollection<ProdNotaprodutos> ProdNotaprodutos { get; set; }
    }
}
