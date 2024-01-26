using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Endereco
    {
        public Endereco()
        {
            Fornecedors = new HashSet<Fornecedor>();
        }

        public int Idendereco { get; set; }
        public string? Uf { get; set; }
        public string? Cidade { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? Numero { get; set; }
        public string? Cep { get; set; }
        public string? CodigoMunicipio { get; set; }
        public string? Bairro { get; set; }
        public string? Excluido { get; set; }
        public DateTime? DataCadastro { get; set; }
        public string? Longitude { get; set; }
        public string? Latitude { get; set; }

        public virtual ICollection<Fornecedor> Fornecedors { get; set; }
    }
}
