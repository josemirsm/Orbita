using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class BoletoConfig
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public string AgenciaDigito { get; set; }
        public string Banco { get; set; }
        public string Carteira { get; set; }
        public int? Cnab { get; set; }
        public string CodigoCedente { get; set; }
        public string CodigoTransmissao { get; set; }
        public string Conta { get; set; }
        public string ContaDigito { get; set; }
        public string Contrato { get; set; }
        public string Convenio { get; set; }
        public string DigitoAgenciaConta { get; set; }
        public bool? EnviarObs { get; set; }
        public bool? ExibirTelaConfig { get; set; }
        public int? IdEmpresa { get; set; }
        public int? Layout { get; set; }
        public string LocalPagamento { get; set; }
        public string Mensagem1 { get; set; }
        public string Mensagem2 { get; set; }
        public string Modalidade { get; set; }
        public bool? MostrarProgresso { get; set; }
        public bool? Previsualizar { get; set; }
        public int? TipoCarteira { get; set; }
        public int? TipoCobranca { get; set; }
        public int? TipoDocumento { get; set; }
        public int? TipoImpressao { get; set; }
        public string Variacao { get; set; }
        public int Sequencia { get; set; }
        public int SequenciaRemessa { get; set; }
        public int DiasLimitePagamento { get; set; }
    }
}
