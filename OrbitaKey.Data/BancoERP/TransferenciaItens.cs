using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    //TODO: Remover essas anotações
    [Table("TransferenciaItens")]
    public partial class TransferenciaItens
    {        
        [Key]
        public int Id { get; set; }
        public int IdTransferencia { get; set; }
        [Required]
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Un { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Gravacao { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal Quantidade { get; set; }
        [Column(TypeName = "decimal(13, 3)")]
        public decimal ValorUnitario { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal ValorTotal { get; set; }
        public string Obs { get; set; }
        [DefaultValue(0)]
        public int IdLocalizacaoProduto { get; set; }
    }
}
