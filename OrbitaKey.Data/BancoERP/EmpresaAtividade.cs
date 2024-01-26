using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class EmpresaAtividade
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int? IdEmpresa { get; set; }
    }
}
