using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    [Table("view_materiaprima")]
    public class ViewMateriaPrima
    {
        [Key]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int IdEmpresa { get; set; }
        public decimal CustoUnitario { get; set; }
        public string Un { get; set; }
        public decimal Quantidade { get; set; }
        public decimal CustoProporcional { get; set; }
        public int? IdProdutoProduzidoY { get; set; }
        public int? IdProdutoProduzidoX { get; set; }
    }
}
