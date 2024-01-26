using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Produto
    {
        public Produto()
        {
            Customedio = new HashSet<Customedio>();
            EstoqueNavigation = new HashSet<Estoque>();
            Precomedio = new HashSet<Precomedio>();
            Saidas = new HashSet<Saidas>();
        }

        public int Idproduto { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? Atualizacao { get; set; }
        public int? Balanca { get; set; }
        public string Barras2 { get; set; }
        public string Barras3 { get; set; }
        public string Barras4 { get; set; }
        public string Barras5 { get; set; }
        public string Barras6 { get; set; }
        public string Cest { get; set; }
        public int? Codigo { get; set; }
        public string CodigoBarras { get; set; }
        public int? CodigoGrupo { get; set; }
        public int? CodigoMarca { get; set; }
        public int? CodigoSubgrupo { get; set; }
        public int? CodigoUnidadeMedida { get; set; }
        public decimal? CustoManual { get; set; }
        public decimal? CustoMedio { get; set; }
        public DateTime? DataCadastro { get; set; }
        public decimal? DescontoPermitido { get; set; }
        public string Descricao { get; set; }
        public string DiasValidade { get; set; }
        public decimal? Estoque { get; set; }
        public decimal? Estoque2 { get; set; }
        public decimal? EstoqueMaximo { get; set; }
        public decimal? EstoqueMinimo { get; set; }
        public bool? Excluido { get; set; }
        public int? Grade { get; set; }
        public int? IdProdutoEspecifico { get; set; }
        public int? Idtributacao { get; set; }
        public byte[] Imagem { get; set; }
        public string Local { get; set; }
        public decimal? Margem { get; set; }
        public decimal? MargemMinima { get; set; }
        public decimal? Mva { get; set; }
        public string Ncm { get; set; }
        public string Observacao { get; set; }
        public int? PermitirAlterarDescricao { get; set; }
        public decimal? Peso { get; set; }
        public decimal? Preco3 { get; set; }
        public decimal? Preco4 { get; set; }
        public decimal? Preco5 { get; set; }
        public decimal? Preco6 { get; set; }
        public decimal? PrecoAtacado { get; set; }
        public int? PrecoLivre { get; set; }
        public decimal? PrecoVarejo { get; set; }
        public int? ProdutoEspecifico { get; set; }
        public decimal? QuantPreco3 { get; set; }
        public decimal? QuantPreco4 { get; set; }
        public decimal? QuantPreco5 { get; set; }
        public decimal? QuantPreco6 { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public string Referencia5 { get; set; }
        public int? Servico { get; set; }
        public decimal? UltimoCusto { get; set; }
        public bool Uso { get; set; }
        public int? VendaFracionada { get; set; }
        public bool ProducaoPropria { get; set; }
        public bool MateriaPrima { get; set; }
        /// <summary>
        /// Percentual de comissão a ser aplicado por produto no momento da venda
        /// </summary>
        public decimal Comissao { get; set; }
        /// <summary>
        /// Fator ultiplicação para evidar venda de quantidades não permitidas
        /// </summary>
        public decimal Multiplo { get; set; }
        /// <summary>
        /// Tipos específicos do Sped
        ///00 – Mercadoria para Revenda;
        ///01 – Matéria-prima;
        ///02 – Embalagem;
        ///03 – Produto em Processo;
        ///04 – Produto Acabado;
        ///05 – Subproduto;
        ///06 – Produto Intermediário;
        ///07 – Material de Uso e Consumo;
        ///08 – Ativo Imobilizado;
        ///09 – Serviços;
        ///10 – Outros insumos;
        ///99 – Outras
        /// </summary>
        public int TipoItem { get; set; }

        public virtual ICollection<Customedio> Customedio { get; set; }
        public virtual ICollection<Estoque> EstoqueNavigation { get; set; }
        public virtual ICollection<Precomedio> Precomedio { get; set; }
        public virtual ICollection<Saidas> Saidas { get; set; }
    }
}
