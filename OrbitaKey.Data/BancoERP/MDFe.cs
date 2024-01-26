using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class MDFe
    {
        public int Id { get; set; }
        public string Chave { get; set; }
        public int cUF { get; set; }
        public int tpAmb { get; set; }
        public int tpEmit { get; set; }
        public int mod { get; set; }
        public int serie { get; set; }
        public int nMDF { get; set; }
        public int cmdf { get; set; }
        public int modal { get; set; }
        public DateTime dhemi { get; set; }
        public int tpEmis { get; set; }
        public int procEmi { get; set; }
        public string verProc { get; set;}
        public string UFIni { get; set; }
        public string UFFim { get; set; }
        public int tpTransp { get; set; }
        public string RNTRC { get; set; }
        public string CNPJ { get; set; }
        public string IE { get; set; }
        public string Xnome { get; set; }
        public string XFant { get; set; }
        public string XLgr { get; set; }
        public string nro { get; set; }
        public string XCpl { get; set; }
        public string XBairro { get; set; }
        public string cMun { get; set; }
        public string xMun { get; set; }
        public string cep { get; set; }
        public string UF { get; set; }
        public string fone { get; set; }
        public string email { get; set; }
        public string infCpl { get; set; }
        public string infAdFisco { get; set; }
        public int qCTe { get; set; }
        public int qNFe { get; set; }
        public decimal vCarga { get; set; }
        public int cUnid { get; set; }
        public decimal qCarga { get; set; }
        public string cMunCarrega { get; set; }
        public string xMunCarrega { get; set; }
        public string cMunDescarga { get; set; }
        public string xMunDescarga { get; set; }
        public int IdEmpresa { get; set; }
        public int IdUsuario { get; set; }
        public bool Autorizada { get; set; }
        public bool Finalizada { get; set; }
        public bool Cancelada { get; set; }
        /// <summary>
        /// Justificativa de cancelamento da MDFe
        /// </summary>
        public string xCancelamento { get; set; }
        public string CancelamentoUsuario { get; set; }
        public bool Excluida { get; set; }
        public bool Validada { get; set; }
        public DateTime? dhEnc { get; set; }
    }
}
