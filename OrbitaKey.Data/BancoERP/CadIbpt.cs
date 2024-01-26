using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class CadIbpt
    {
        public int Id { get; set; }
        public string Chave { get; set; }
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public double? Estadual { get; set; }
        public string Ex { get; set; }
        public string Fonte { get; set; }
        public double? Importadosfederal { get; set; }
        public double? Municipal { get; set; }
        public double? Nacionalfederal { get; set; }
        public int? Tipo { get; set; }
        public string Versao { get; set; }
        public string Vigenciafim { get; set; }
        public string Vigenciainicio { get; set; }
    }
}
