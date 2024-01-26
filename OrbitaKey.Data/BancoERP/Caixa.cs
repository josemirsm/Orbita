using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Caixa
    {
        public Caixa()
        {
            Movimentocaixa = new HashSet<Movimentocaixa>();
        }

        public int Idcaixa { get; set; }
        public int? Aberto { get; set; }
        public DateTime Abertura { get; set; }
        public int? Conferido { get; set; }
        public DateTime? Encerramento { get; set; }
        public decimal? Entradas { get; set; }
        public int? IdUsuario { get; set; }
        public string Observacao { get; set; }
        public string Operador { get; set; }
        public decimal? Saidas { get; set; }
        public decimal? SaldoFinal { get; set; }
        public decimal? SaldoInicial { get; set; }

        public virtual ICollection<Movimentocaixa> Movimentocaixa { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
