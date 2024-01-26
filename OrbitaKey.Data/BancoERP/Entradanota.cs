using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Entradanota
    {
        public Entradanota()
        {
            Entradaitem = new HashSet<Entradaitem>();
        }

        public int Identradanota { get; set; }
        public string CMun { get; set; }
        public string CPais { get; set; }
        public int? Cancelada { get; set; }
        public string Cep { get; set; }
        public string ChaveAcesso { get; set; }
        public int? CodigoFornecedor { get; set; }
        public int? CodigoVendedor { get; set; }
        public string CpfCnpj { get; set; }
        public DateTime? DataChegada { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataLancamento { get; set; }
        public DateTime? DhSaiEnt { get; set; }
        public string Email { get; set; }
        public int? Excluida { get; set; }
        public int? FinNfe { get; set; }
        public string Fone { get; set; }
        public int? IdDest { get; set; }
        public int? IdEmpresa { get; set; }
        public string IdEstrangeiro { get; set; }
        public int? IdXml { get; set; }
        public int? Idusuario { get; set; }
        public string Ie { get; set; }
        public string Im { get; set; }
        public int? IndFinal { get; set; }
        public int? IndIedest { get; set; }
        public int? IndPres { get; set; }
        public string Isuf { get; set; }
        public int? Liberada { get; set; }
        public int? ModFrete { get; set; }
        public string Modelo { get; set; }
        public string NatOp { get; set; }
        public string NomeVendedor { get; set; }
        public int? NotaImportada { get; set; }
        public string Nro { get; set; }
        public int? NumeroNf { get; set; }
        public string Serie { get; set; }
        public string Situacao { get; set; }
        public int? TpAmb { get; set; }
        public int? TpEmis { get; set; }
        public int? TpImp { get; set; }
        public int? TpNf { get; set; }
        public string Uf { get; set; }
        public decimal? VBc { get; set; }
        public decimal? VBcst { get; set; }
        public decimal? VCofins { get; set; }
        public decimal? VDesc { get; set; }
        public decimal? VDesp { get; set; }
        public decimal? VFrete { get; set; }
        public decimal? VIcms { get; set; }
        public decimal? VIcmsdeson { get; set; }
        public decimal? VIi { get; set; }
        public decimal? VIpi { get; set; }
        public decimal? VNf { get; set; }
        public decimal? VOutro { get; set; }
        public decimal? VPis { get; set; }
        public decimal? VProd { get; set; }
        public decimal? VSeg { get; set; }
        public decimal? VSt { get; set; }
        public decimal? VTotTrib { get; set; }
        public decimal? VTroco { get; set; }
        public string XCpl { get; set; }
        public string XLgr { get; set; }
        public string XMun { get; set; }
        public string XNome { get; set; }
        public string XPais { get; set; }
        public string InfAdFisco { get; set; }
        public string InfCpl { get; set; }
        /// <summary>
        /// 0 - A Vista
        /// 1 - A prazo
        /// 9 - Sem pagamento
        /// </summary>
        public int IndPag { get; set; }

        public virtual ICollection<Entradaitem> Entradaitem { get; set; }
    }
}
