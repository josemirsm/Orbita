using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Config
    {
        public int Idconfig { get; set; }
        public int ContagemDocumento { get; set; }
        public string? DiretorioBackup { get; set; }
        public int IdEmpresa { get; set; }
        /// <summary>
        /// Valor do salário mínimo atual, para calculo das mensalidades
        /// </summary>
        public decimal SalarioAtual { get; set; }
    }
}
