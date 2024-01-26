using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class MDFeVeiculo
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public int IdMDFe { get; set; }
        public string cInt { get; set; }
        public string placa { get; set; }
        public string RENAVAM { get; set; }
        public decimal tara { get; set; }
        public decimal capKG { get; set; }
        public decimal capM3 { get; set; }
        public string UF { get; set; }
        public string CNPJCPF { get; set; }
        public string RNTRC { get; set; }
        public string xNome { get; set; }
        public string IE { get; set; }
        public string UFProp { get; set; }
        /// <summary>
        /// Tipo Proprietário. 0-TAC – Agregado; 1-TAC Independente; 2 – Outros
        /// </summary>
        public string tpProp { get; set; }
        /// <summary>
        /// 01 - Truck;
        /// 02 - Toco;
        /// 03 - Cavalo Mecânico;
        /// 04 - VAN;
        /// 05 - Utilitário;
        /// 06 - Outros
        /// </summary>
        public int tpRod { get; set; }
        public string tpCar { get; set; }
        /// <summary>
        /// xNome. Nome do motorista
        /// </summary>
        public string xMotorista { get; set; }
        /// <summary>
        /// CPF do Motorista
        /// </summary>
        public string CPF { get; set; }

    }
}
