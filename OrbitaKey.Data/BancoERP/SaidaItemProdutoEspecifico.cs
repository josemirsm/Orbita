using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class SaidaItemProdutoEspecifico
    {
        public int IdSaidaItemProdutoEspecifico { get; set; }
        public int? VNTipoOperacao { get; set; }
        public string VNChassiDoVeiculo { get; set; }
        public string VNCor { get; set; }
        public string VNDescricaoCor { get; set; }
        public string VNPotenciaMotor { get; set; }
        public string VNCilindradas { get; set; }
        public string VNPesoLiquido { get; set; }
        public string VNPesoBruto { get; set; }
        public string VNSerial { get; set; }
        public string VNTipoCombustivel { get; set; }
        public string VNNumeroMotor { get; set; }
        public string VNCapacidadeMaximaTracao { get; set; }
        public string VNDistanciaEntreEixos { get; set; }
        public int? VNAnoModeloFabricacao { get; set; }
        public int? VNAnoFabricacao { get; set; }
        public string VNTipoPintura { get; set; }
        public int? VNTipoVeiculo { get; set; }
        public int? VNEspecieVeiculo { get; set; }
        public string VNCondicaoVIN { get; set; }
        public int? VNCondicaoVeiculo { get; set; }
        public int? VNCodigoMarcaModelo { get; set; }
        public int? VNCodigoCor { get; set; }
        public int? VNCapacidadeMaximaLotacao { get; set; }
        public int? VNRestricao { get; set; }
    }
}
