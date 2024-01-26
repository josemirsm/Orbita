using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.Models
{
    public class CashCliente
    {
        public int Id {  get; set; }
        public Guid Guid {  get; set; }
        public string CnpjRepresentante {  get; set; } = string.Empty;
        public string CnpjEmpresa {  get; set; } = string.Empty;
        public string CpfCliente { get; set; } = string.Empty;
        public string NomeRazao { get; set; } = string.Empty;
        public string NomeFantasia { get; set; } = string.Empty;
        public DateTime? Nascimento { get; set; }
        public DateTime Data { get; set; }
        public bool Sincronizado { get; set; } = false;

        public string Email { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
        public string Celular2 { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Telefone2 { get; set; } = string.Empty;

        public string Logradouro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;
        public string Codmun { get; set; } = string.Empty;
    }
}
