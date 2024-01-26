using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class AuxIbpt
    {
        public int Id { get; set; }
        public string Chave { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Estadual { get; set; }
        public string Ex { get; set; }
        public string Fonte { get; set; }
        public string Importadosfederal { get; set; }
        public string Municipal { get; set; }
        public string Nacionalfederal { get; set; }
        public string Tipo { get; set; }
        public string Versao { get; set; }
        public string Vigenciafim { get; set; }
        public string Vigenciainicio { get; set; }
    }
}
