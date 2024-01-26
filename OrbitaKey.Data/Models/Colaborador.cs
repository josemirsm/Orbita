using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Colaborador
    {
        public int Idcolaborador { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string? Funcao { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateOnly? DataNascimento { get; set; }
        public int? Ativo { get; set; }
        public DateOnly? DataDesligamento { get; set; }
    }
}
