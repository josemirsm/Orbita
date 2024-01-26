using System;
using System.Collections.Generic;
using OrbitaKey.Data.BancoERP;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Usuario
    {

        public int Idusuario { get; set; }
        public int? Ativo { get; set; }
        public string Chave { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string Email { get; set; }
        public int? Excluido { get; set; }
        public int? Logado { get; set; }
        public string Login { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Sobrenome { get; set; }
        public string UltimaMaquina { get; set; }
        public string Cartao { get; set; }
        public bool CartaoSemSenha { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public virtual ICollection<Caixa> Caixa { get; set; }
    }
}
