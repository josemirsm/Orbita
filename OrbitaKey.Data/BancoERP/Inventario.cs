using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Inventario
    {
        public Inventario()
        {
            Produtoinventario = new HashSet<Produtoinventario>();
        }

        public int Idinventario { get; set; }
        public DateTime? CompetenciaFim { get; set; }
        public DateTime? CompetenciaInicio { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataImpressao { get; set; }
        public int? Excluido { get; set; }
        public int? Fechado { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdUsuario { get; set; }
        public int? Ordem { get; set; }

        public virtual ICollection<Produtoinventario> Produtoinventario { get; set; }
    }
}
