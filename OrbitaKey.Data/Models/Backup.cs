using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.Models
{
    public partial class Backup
    {
        public int Idbackup { get; set; }
        public string? Maquina { get; set; }
        public DateTime? DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
    }
}
