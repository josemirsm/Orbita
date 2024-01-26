using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Credito
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public int? IdVenda { get; set; }
        /// <summary>
        /// Em casos de uso do crédito deverá ter um tipo de documento vinculado
        /// </summary>
        public int? IdDocumento { get; set; }
        public int IdAdiantamento { get; set; }
        public bool Cancelado { get; set; }
        public int CodigoCliente { get; set; }
        /// <summary>
        /// Sempre que o valor for adicionado na conta do cliente
        /// </summary>
        public bool Entrada { get; set; }
        /// <summary>
        /// Sempre que o valor for abatido da conta do cliente
        /// </summary>
        public bool Saida { get; set; }
        public string Descricao { get; set; }
        public string Historico { get; set; }
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }

    }
}
