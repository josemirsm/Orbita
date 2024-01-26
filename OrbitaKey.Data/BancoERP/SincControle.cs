using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class SincControle
    {        
        public int Id { get; set; }
        public string Guid { get; set; }
        public int EmpresaId { get; set; }
        public string EmpresaGuid { get; set; }
        public string SicronizadorGuid { get; set; }

        /// <summary>
        /// Intervalo de sincronização configurado. 
        /// Serve para quem está buscando informação conseguir calcular se a sincronização está atrasada ou dentro do prazo estipulado
        /// </summary>
        public int Intervalo { get; set; }

        /// <summary>
        /// Indica se quem gravou o status é um servidor
        /// </summary>
        public bool Servidor { get; set; }

        /// <summary>
        /// Indica se quem gravou o status é um cliente
        /// </summary>
        public bool Cliente { get; set; }

        /// <summary>
        /// Data e hora local do computador que está sincronizando
        /// </summary>
        public DateTime Data { get; set; }

        /// <summary>
        /// Data e hora do servidor de sincronização
        /// </summary>
        public DateTime DataServidor { get; set; }

    }
}
