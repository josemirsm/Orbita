using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Rota
    {
        public int Idrota { get; set; }
        public int Ativo { get; set; }
        public decimal? Comissao { get; set; }
        public decimal? ComissaoDesconto { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Descricao { get; set; }
        public int Excluido { get; set; }
        public string Observacao { get; set; }
    }
}
