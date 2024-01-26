using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Cliente
    {
        public int IdCliente { get; set; }
        public bool? Ativo { get; set; }
        public DateTime? Atualizacao { get; set; }
        public int Codigo { get; set; }
        public string CpfCnpj { get; set; }
        public bool? Excluido { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeOuRazao { get; set; }
    }
}
