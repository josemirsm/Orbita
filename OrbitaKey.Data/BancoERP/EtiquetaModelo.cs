using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class EtiquetaModelo
    {
        public int Id { get; set; }
        /// <summary>
        /// Código da etiqueta na base colaborativa
        /// </summary>
        public int? Codigo { get; set; }
        public string Linguagem { get; set; }
        public string Campos { get; set; }
        public string Descricao { get; set; }
        public string Conteudo { get; set; }
        public decimal Altura { get; set; }
        public decimal Largura { get; set; }
        public bool Compartilhada { get; set; }
        public DateTime DataCriacao { get; set; }
        public int Colunas { get; set; }
        /// <summary>
        /// Imagem a ser impressa na etiqueta
        /// </summary>
        public byte[] Imagem { get; set; }
        public byte[] Imagem2 { get; set; }
        /// <summary>
        /// Imagem da etiqueta ja pronta para ser exibida como modelo
        /// </summary>
        public byte[] Modelo { get; set; }
        public int IdTipoDocumento { get; set; }
    }
}
