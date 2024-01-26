using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Pagamentovenda
    {
        public int IdPagamentoVenda { get; set; }
        public decimal? AdicionalParcelamento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public decimal? DescontoFp { get; set; }
        public string DescricaoPagamento { get; set; }
        public string DescricaoSefaz { get; set; }
        public int? IdPc3 { get; set; }
        public int? IdtipoDocumento { get; set; }
        public int? Idvenda { get; set; }
        public int? NumeroParcela { get; set; }
        public int? QuantidadeParcelas { get; set; }
        public int? Tef { get; set; }
        public string TefAdquirente { get; set; }
        public string TefArquivoRetorno { get; set; }
        public int? TefCodigoControleAc { get; set; }
        public string TefCodigoControlePayGo { get; set; }
        public string TefDiferenciadaCliente { get; set; }
        public string TefDiferenciadaEstabelecimento { get; set; }
        public string TefNsu { get; set; }
        public string TefResumidaCliente { get; set; }
        public string TefViaCompleta { get; set; }
        public decimal? Valor { get; set; }
        /// <summary>
        /// Criado para usar em conjunto com a configuração de fixar preços
        /// </summary>
        public decimal DescontoFixo { get; set; }
        /// <summary>
        /// Criado para usar em conjunto com a configuração de fixar preços
        /// </summary>
        public decimal AcrescimoFixo { get; set; }
    }
}
