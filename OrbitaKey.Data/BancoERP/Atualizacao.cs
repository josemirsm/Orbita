using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Atualizacao
    {
        public int Id { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public DateTime? DataScript { get; set; }
        public string Descricao { get; set; }
        public int? Sucesso { get; set; }
    }
}
