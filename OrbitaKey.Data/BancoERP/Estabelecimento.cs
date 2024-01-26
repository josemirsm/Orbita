using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Estabelecimento
    {
        public Estabelecimento()
        {
            Estoque = new HashSet<Estoque>();
            Movimentoitens = new HashSet<Movimentoitens>();
            Saidanota = new HashSet<Saidanota>();
        }

        public int IdEstabelecimento { get; set; }
        public decimal? AliqCreditoSimples { get; set; }
        public bool? Ativo { get; set; }
        public string Cnpj { get; set; }
        public string CpfCnpjContador { get; set; }
        public int? Crt { get; set; }
        public string CscHomo { get; set; }
        public string CscProd { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string EmailContabilidade { get; set; }
        public bool? Excluido { get; set; }
        public string IdCertificado { get; set; }
        public int? IdCscHomo { get; set; }
        public int? IdCscProd { get; set; }
        public int Idcontato { get; set; }
        public int Idendereco { get; set; }
        public string Iestadual { get; set; }
        public string Im { get; set; }
        public byte[] Logo { get; set; }
        public string NomeFantasia { get; set; }
        public int? NumeroDav { get; set; }
        public int? NumeroNfceHomo { get; set; }
        public int? NumeroNfceProd { get; set; }
        public int? NumeroNfeHomo { get; set; }
        public int? NumeroNfeProd { get; set; }
        public int? NumeroOrc { get; set; }
        public int? PortaAcbr { get; set; }
        public string Razao { get; set; }
        public string SenhaCertificado { get; set; }
        public int? SerieNfce { get; set; }
        public int? SerieNfe { get; set; }
        /// <summary>
        /// Gravar a ultima data de consulta de consulta DFe para usar em caso de cStat=137, permitindo a consulta apenas depois de 1h
        /// </summary>
        public DateTime? UltimaConsultaDFe { get; set; }
        /// <summary>
        /// Usar este bloqueio toda vez que o retorno do DistribuicaoDFe for cStat=137
        /// </summary>
        public bool BloquearDFe { get; set; }
        public virtual ICollection<Estoque> Estoque { get; set; }
        public virtual ICollection<Movimentoitens> Movimentoitens { get; set; }
        public virtual ICollection<Saidanota> Saidanota { get; set; }
        public virtual Contato IdcontatoNavigation { get; set; }
        public virtual Endereco IdenderecoNavigation { get; set; }
    }
}
