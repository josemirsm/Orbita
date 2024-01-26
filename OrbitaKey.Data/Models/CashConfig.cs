using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.Models
{
    public class CashConfig
    {
        public int Id {  get; set; }
        public Guid Guid {  get; set; }
        public DateTime Data { get; set; }
        public string CnpjRepresentante {  get; set; } = string.Empty;
        public string CnpjEmpresa {  get; set; } = string.Empty;        
        public string MensagemSucesso { get; set; } = string.Empty;
        public string Instagram { get; set; } = string.Empty;
        public string Site { get; set; } = string.Empty;
    }
}
