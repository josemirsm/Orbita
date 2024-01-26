using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class LocalizacaoSaldo
    {
        public int Id { get; set; }
        public int IdLocalizacao { get; set; }
        public int IdEmpresa { get; set; }
        public decimal Saldo { get; set; }
    }
}
