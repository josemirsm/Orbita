using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Etiqueta
    {
        public int IdEtiqueta { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool? Entrega { get; set; }
        public int? IdSaida { get; set; }
        public int? Quantidade { get; set; }
        public DateTime? Validade { get; set; }
        public int? IdGrade { get; set; }
        /// <summary>
        /// Id do produto na tabela de TabelaprecoItem, usar para capturar o novo preço do produto, antes mesmo de ele ser liberado para o cadastro
        /// </summary>
        public int? TabelaItemId { get; set; }
    }
}
