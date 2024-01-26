using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    /// <summary>
    /// 13 02 2023
    /// Essa tabela está com um problema e não funciona corretamente usando o EF
    /// A solução seria corrigir no contexto para retirar a chave que está composta por idMovimento e IdEstabelecimento, deixando apenas IdMovimento
    /// Isso não foi feito ainda pelo fato de ser uma tabela que frequentemente tem milhões de registros e certamente dará problema no update
    /// Se houver problema nessa tabela e não for devidamente retificado no mesmo momento poderá trazer problema de confiabilidade para o sistema.
    /// </summary>
    public partial class Movimentoitens
    {
        public int IdMovimento { get; set; }
        public int IdEstabelecimento { get; set; }
        public int CodigoProduto { get; set; }
        public DateTime? DataHora { get; set; }
        public string Descricao { get; set; }
        public int? IdBalanco { get; set; }
        public int? IdEntrada { get; set; }
        public int? IdSaida { get; set; }
        public int? IdTransferencia { get; set; }
        public decimal? Quantidade { get; set; }
        public string TipoMovimento { get; set; }
        public int IdLocalizacaoProduto { get; set; }

        public virtual Estabelecimento IdEstabelecimentoNavigation { get; set; }
    }
}
