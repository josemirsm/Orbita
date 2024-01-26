using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Contato
    {
        public Contato()
        {
            Fornecedors = new HashSet<Fornecedor>();
        }

        public int Idcontato { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? Telefone { get; set; }
        public string? Telefone2 { get; set; }
        public string? Celular { get; set; }
        public string? Celular2 { get; set; }
        public string? Ramal { get; set; }
        public string? NomeRepresentante { get; set; }
        public string? TelefoneRepresentante { get; set; }
        public int? Excluido { get; set; }
        public string? Site { get; set; }

        public virtual ICollection<Fornecedor> Fornecedors { get; set; }
    }
}
