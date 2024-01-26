using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Conta
    {
        public int Id { get; set; }
        public string Agencia { get; set; }
        public int? Ativa { get; set; }
        public int? Bancaria { get; set; }
        public string Banco { get; set; }
        public int? Codigo { get; set; }
        public DateTime? DataCriacao { get; set; }
        public string Descricao { get; set; }
        public bool? Entrada { get; set; }
        public int? Excluida { get; set; }
        public string Numero { get; set; }
        public string Observacao { get; set; }
        public bool? Subconta { get; set; }
    }
}
