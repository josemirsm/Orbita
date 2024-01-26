using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class PreProducao
    {
        public int Id { get; set; }
        public int CodigoCliente { get; set; }
        public string Cliente { get; set; }
        public DateTime DataCriacao { get; set; }
        public bool Finalizado { get; set; }
        public bool Cancelada { get; set; }
        public int Prioridade { get; set; }
        public decimal Valor { get; set; }
        public int IdUsuario { get; set; }
        public string Obs { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public DateTime DataPrevista { get; set; }
    }
}
