using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class NfseServico
    {
        public int Id { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? AliquotaIss { get; set; }
        public decimal? BaseCalculo { get; set; }
        public int? Codigo { get; set; }
        public decimal? Desconto { get; set; }
        public string Descricao { get; set; }
        public int IdNota { get; set; }
        public decimal? Quantidade { get; set; }
        public decimal? Total { get; set; }
        public string Unidade { get; set; }
        public decimal? Valor { get; set; }
        public decimal? ValorIss { get; set; }

        public virtual Nfse IdNotaNavigation { get; set; }
    }
}
