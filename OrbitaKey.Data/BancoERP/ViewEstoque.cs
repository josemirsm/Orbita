using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    //TODO: Algum problema em deixar as anotações nas tabelas?
    [Table("view_estoque")]
    public class ViewEstoque
    {
        [Key]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public decimal? Saldo { get; set; }
        public decimal? PrecoVarejo { get; set; }
        public decimal? PrecoAtacado { get; set; }
        public int Idestabelecimento { get; set; }
        public string Un { get; set; }
        public string EAN { get; set; }
        public string Barras2 { get; set; }
        public string Barras3 { get; set; }
        public string Barras4 { get; set; }
        public string Barras5 { get; set; }
        public string Barras6 { get; set; }
        public string Referencia { get; set; }
        public string Referencia2 { get; set; }
        public string Referencia3 { get; set; }
        public string Referencia4 { get; set; }
        public string Referencia5 { get; set; }
        public decimal? CustoMedio { get; set; }
        public bool Ativo { get; set; }
        public string Ncm { get; set; }
        public string Cest { get; set; }
        public string Local { get; set; }
        public string Marca { get; set; }
        public decimal? Reservado { get; set; }
    }
}
