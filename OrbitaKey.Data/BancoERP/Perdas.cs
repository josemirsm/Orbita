using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP.Enums;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Perdas
    {
        public int Id { get; set; }
        public bool Fornecedor { get; set; }
        public bool Baixado { get; set; }
        public int Codigo { get; set; }
        public int CodigoFornecedor { get; set; }
        public int CodigoCliente { get; set; }
        
        /// <summary>
        /// Data que houve a movimentação
        /// </summary>
        public DateTime? DataCadastro { get; set; }
        /// <summary>
        /// Data que o produto foi enviado para o fornecedor, em caso de garantia
        /// </summary>
        public DateTime? DataEnvio { get; set; }

        /// <summary>
        /// Data em que houve finalização do processo com o fornecedor
        /// </summary>
        public DateTime? DataBaixa { get; set; }
        public string Descricao { get; set; }
        /// <summary>
        /// Número da nota de crédito, que alguns fornecedores dão para abatimento de novas compras
        /// </summary>
        public string NotaCredito { get; set; }

        /// <summary>
        /// Referencia do produto na hora que é efetivado o cadastro
        /// </summary>
        public string Referencia { get; set; }
        public int? IdEmpresa { get; set; }
        public string Obs { get; set; }
        public decimal Quantidade { get; set; }
        public string Un { get; set; }
        public TipoPerda Tipo { get; set; }
        public TipoDestinatario? TipoDestinatario { get; set; }
        public TipoMovimento? TipoMovimento { get; set; }
    }
}
