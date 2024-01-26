using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.Models
{
    /// <summary>
    /// Valor da mensalidade negociada com o cliente
    /// </summary>
    public class Financeiro
    {
        public int Id { get; set; }
        public int EmpresaId { get; set; }
        public Guid Guid { get; set; }
        public int ClienteId { get; set; }
        /// <summary>
        /// Para validação em casos de alteração indevida do CNPJ
        /// </summary>
        public string CNPJ { get; set; }
        public decimal SalarioReferencia { get; set; }
        public decimal PercentualNegocioado { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string Obs { get; set; }
        public int UsuarioId { get; set; }
        public bool Cancelado { get; set; }
        public int CanceladoUsuarioId { get; set; }
        public int TipoDocumentoId { get; set; }
        public Enuns.Financeiro.Tipo TipoFinanceiro { get; set; }
    }
}
