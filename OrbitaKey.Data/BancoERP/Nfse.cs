using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Nfse
    {
        public Nfse()
        {
            NfseServico = new HashSet<NfseServico>();
            NfseTomador = new HashSet<NfseTomador>();
        }

        public int Id { get; set; }
        public decimal? Acrescimo { get; set; }
        public decimal? AliquotaIss { get; set; }
        public bool? Autorizada { get; set; }
        public decimal? BaseCalculo { get; set; }
        public bool? Cancelada { get; set; }
        public bool? CancelamentoEnviado { get; set; }
        public string Cnae { get; set; }
        public string CodigoAtividade { get; set; }
        public string CodigoCnae { get; set; }
        public string CodigoVerificacao { get; set; }
        public DateTime? Competencia { get; set; }
        public DateTime? DataCancelamento { get; set; }
        public decimal? Desconto { get; set; }
        public string DescricaoServico { get; set; }
        public DateTime? Emissao { get; set; }
        public int? ExigibilidadeIss { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdNfOrigem { get; set; }
        public int? IncentivoFiscal { get; set; }
        public int? IssRetido { get; set; }
        public string JustificativaCancelamento { get; set; }
        public string Modelo { get; set; }
        public string MunicipioIncidencia { get; set; }
        public string MunicipioPrestacao { get; set; }
        public int? Numero { get; set; }
        public string NumeroProcesso { get; set; }
        public string Obs { get; set; }
        public int? RegimeEspecialTributacao { get; set; }
        public string Serie { get; set; }
        public int? SimplesNacional { get; set; }
        public bool? Substituida { get; set; }
        public int? Tipo { get; set; }
        public string TipoAtividade { get; set; }
        public decimal? TotalNota { get; set; }
        public decimal? ValorIss { get; set; }
        public decimal? ValorServico { get; set; }
        public byte[] Xml { get; set; }

        public virtual ICollection<NfseServico> NfseServico { get; set; }
        public virtual ICollection<NfseTomador> NfseTomador { get; set; }
    }
}
