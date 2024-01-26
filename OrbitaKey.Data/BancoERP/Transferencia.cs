using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrbitaKey.Data.BancoERP
{
    [Table("Transferencia")]
    public partial class Transferencia
    {
        //TODO: Remover essas anotações
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdEmpresa { get; set; }
        [Required]
        public int IdEmpresaDestino{ get; set; }
        [Required]
        public int CodigoCliente { get; set; }
        public string NomeCliente { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//Verificar se essa data é redefinida em casos de restauração do banco de dados , caso posivo é preciso ver uma outra forma, em ultimo caso usar a função "now()"
        public DateTime Gravacao { get; set; }
        public DateTime Emissao { get; set; }
        [Column(TypeName = "decimal(13, 2)")]
        public decimal Valor { get; set; }
        public string Obs { get; set; }
        public bool Cancelada { get; set; }
        public bool Excluida { get; set; }
        public bool Finalziada { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
    }
}
