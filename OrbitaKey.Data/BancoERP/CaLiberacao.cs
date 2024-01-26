using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class CaLiberacao
    {
        public int IdcaLiberacao { get; set; }
        public int? AutorizacaoJaUsada { get; set; }
        public int? Autorizado { get; set; }
        public string Descricao { get; set; }
        public string DescricaoConfig { get; set; }
        public DateTime? DhResposta { get; set; }
        public DateTime? DhSolicitacao { get; set; }
        public DateTime? DhUtilizacao { get; set; }
        public int? IdAutorizador { get; set; }
        public int? IdSaida { get; set; }
        public int? IdSolicitante { get; set; }
        public string Justificativa { get; set; }
        public int? MensagemExibida { get; set; }
        public string NomeAutorizador { get; set; }
        public string NomeSolicitante { get; set; }
    }
}
