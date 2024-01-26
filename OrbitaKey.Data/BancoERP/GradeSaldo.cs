using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class GradeSaldo
    {
        public int Id { get; set; }
        public int IdGrade { get; set; }
        public int IdEmpresa { get; set; }
        public decimal Saldo { get; set; }
        public decimal Custo { get; set; }
    }
}
