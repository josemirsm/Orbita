using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Unidademedida
    {
        public int IdunidadeMedida { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? Atualizacao { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string DescricaoCompleta { get; set; }
        public bool? Excluido { get; set; }
    }
}
