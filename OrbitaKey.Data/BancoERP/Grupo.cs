using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Grupo
    {
        public int Idgrupo { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? Atualizacao { get; set; }
        public int Codigo { get; set; }
        public decimal? Comissao { get; set; }
        public string Descricao { get; set; }
        public bool? Excluido { get; set; }
        public string Guid { get; set; }
        public byte[] Imagem { get; set; }
    }
}
