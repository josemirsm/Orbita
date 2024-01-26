using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Tipodocumento
    {
        public Tipodocumento()
        {
            Pagamento = new HashSet<Pagamento>();
            Recebimento = new HashSet<Recebimento>();
        }

        public int IdtipoDocumento { get; set; }
        public decimal? Acrescimo { get; set; }
        public int? Ativo { get; set; }
        public decimal? Deflacao { get; set; }
        public decimal? Desconto { get; set; }
        public string Descricao { get; set; }
        public int? DetalharParcelamento { get; set; }
        public int? DiasDemaisParcelas { get; set; }
        public int? DiasPrimeiraParcela { get; set; }
        public int? DiasToleranciaAtraso { get; set; }
        public int? Excluido { get; set; }
        public int? IdConta { get; set; }
        public int? IdPc3 { get; set; }
        public int? IdPortador { get; set; }
        public decimal? JurosAtraso { get; set; }
        public decimal? JurosMes { get; set; }
        /// <summary>
        /// Valor adicional em reais para cada parcela
        /// </summary>
        public decimal AdicionalMes { get; set; }
        public int? JurosParcela { get; set; }
        public decimal? MultaAtraso { get; set; }
        public int? ParcelamentoMaximo { get; set; }
        public int? ParcelamentoPadrao { get; set; }
        public int? PermiteTroco { get; set; }
        public decimal? PorcentagemAcrescimo { get; set; }
        public decimal? PorcentagemEntrada { get; set; }
        public string TPag { get; set; }
        public int? Tef { get; set; }
        public int? TelaParcelamentoCartao { get; set; }
        public int? TelaParcelamentoCheque { get; set; }
        public int? Tipo { get; set; }
        public string TratamentoEspecifico { get; set; }
        public decimal? ValorMinimo { get; set; }
        public decimal Taxa { get; set; }
        public decimal TaxaMes { get; set; }
        public bool Antecipado { get; set; }
        public int DiasParaRecebimento { get; set; }
        public int? IdAdquirente { get; set; }

        public virtual ICollection<Pagamento> Pagamento { get; set; }
        public virtual ICollection<Recebimento> Recebimento { get; set; }
    }

    enum Tipo 
    {
        Dinheiro,
        Promissoria,
        Boleto,
        Cartao,
        Cheque,
        Credito,
        Outros    
    }
}
