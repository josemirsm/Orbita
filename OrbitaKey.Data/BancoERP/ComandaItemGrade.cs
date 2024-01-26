using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ComandaItemGrade
    {
        public int Id { get; set; }
        public int ComandaItemId { get; set; }
        public string Grade { get; set; }
        public decimal Preco { get; set; }
        public bool Cancelado { get; set; }
        public string CanceladoUsuario { get; set; }
        public DateTime? CanceladoData { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
