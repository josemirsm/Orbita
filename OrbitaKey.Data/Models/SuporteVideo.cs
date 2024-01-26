using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class SuporteVideo
    {
        public int Id { get; set; }
        public string Descricao { get; set; } = null!;
        public string Link { get; set; } = null!;
        public decimal? Avaliacao { get; set; }
        public int? Avaliacoes { get; set; }
        public int? Ordem { get; set; }
        public int? IdEmpresa { get; set; }
    }
}
