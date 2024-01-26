using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class GradeZ
    {
        public int Id { get; set; }
        public bool Ativa { get; set; }
        public string Descricao { get; set; }
        public bool Excluida { get; set; }
    }
}
