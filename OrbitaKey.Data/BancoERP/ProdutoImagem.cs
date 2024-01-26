using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    [Table("ProdutoImagem")]
    public class ProdutoImagem
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        /// <summary>
        /// Caso configurado para armmazenar as imagens no banco
        /// </summary>
        public byte[] Imagem { get; set; }
        /// <summary>
        /// Dependendo da quantidade de imagens, para não pesar no banco optar por armazenar apena o local
        /// </summary>
        public string Caminho { get; set; }

    }
}
