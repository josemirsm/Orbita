using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class BiPagamento
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        /// <summary>
        /// CNPJ do cliente
        /// </summary>
        public string Cnpj { get; set; } = string.Empty;
        /// <summary>
        /// Id do representante que atende o cliente
        /// </summary>
        public int RepresentanteId { get; set; }
        /// <summary>
        /// Modelo da nota
        /// </summary>
        public string Modelo { get; set; } = string.Empty;
        /// <summary>
        /// Valor total da aputação
        /// </summary>
        public decimal Valor { get; set; }
        /// <summary>
        /// QUantidade de paamentos no apurados no lançamento
        /// </summary>
        public int Quantidade { get; set; }
        /// <summary>
        /// Descrição da forma de pagamento na sefaz
        /// </summary>
        public string TipoSefaz { get; set; } = string.Empty;
        /// <summary>
        /// Data em que o laçamento foi criado
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Mês a que se refere a movimentação
        /// </summary>
        public DateTime DataCompetencia { get; set; }
        /// <summary>
        /// Quantidade de notas que tem em cada lançamento
        /// </summary>
        public int QuantidadeNotas { get; set; }
        /// <summary>
        /// Para uso em casos que a venda fiscal não é lançada no caixa
        /// </summary>
        public bool? Caixa { get; set; }
        public bool? Tef { get; set; }
        public string Descricao { get; set; } = string.Empty;
    }
}
