using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string Nome { get; set; } = null!;
        public string? Email { get; set; }
        public string Senha { get; set; } = null!;
        public int? Ativo { get; set; }
        public string? Sobrenome { get; set; }
        public int? Excluido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public int IdEmpresa { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public string? Maquina { get; set; }
        public int? Logado { get; set; }
        public string? Perfil { get; set; }
        public string? Versao { get; set; }
    }
}
