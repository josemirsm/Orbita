using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Oe
    {
        public int Id { get; set; }
        public string Apelido { get; set; }
        public DateTime? DataCriacao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataPrevista { get; set; }
        public bool? Enviada { get; set; }
        public bool? Finalizada { get; set; }
        public int? IdContato { get; set; }
        public int? IdEndereco { get; set; }
        public int? IdPedido { get; set; }
        public string Nome { get; set; }
        public bool? Pendente { get; set; }
        public string Responsavel { get; set; }
    }
}
