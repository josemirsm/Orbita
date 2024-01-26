using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class TabelaPreco
    {
        public int Id { get; set; }
        public string Guid { get; set; }

        /// <summary>
        /// Id da nota de entrada, para casos em que houve uma importação de nota para ajuste dos preços
        /// </summary>
        public int? EntradaId { get; set; }

        /// <summary>
        /// Id da empresa vinculada a nota que foi importada para tabela de preços
        /// </summary>
        public int? EmpresaId { get; set; }
        /// <summary>
        /// Data da digitação
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Data e hora que o usuário deseja aplicar os preços
        /// </summary>
        public DateTime? DataAgendada { get; set; }
        /// <summary>
        /// Tabela de preços cancelada
        /// </summary>
        public bool Cancelado { get; set; }
        /// <summary>
        /// ID do Usuário que fez o cancelamento
        /// </summary>
        public int? CanceladoUsuarioId { get; set; }
        /// <summary>
        /// Nome do Usuário que fez o cancelamento
        /// </summary>
        public string CanceladoUsuario { get; set; }
        /// <summary>
        /// ID do Usuário que criou a tabela de preços
        /// </summary>
        public int UsuarioId { get; set; }
        /// <summary>
        /// Nome do Usuário que criou a tabela de preços
        /// </summary>
        public string Usuario { get; set; }
        /// <summary>
        /// Define se a aplicação foi já realizada
        /// </summary>
        public bool Aplicado { get; set; }
        /// <summary>
        /// Nome do usuário que aplicou
        /// </summary>
        public string AplicadoUsuario { get; set; }
        /// <summary>
        /// Caso seja para o sistema aplicar o preço automaticamente no horário marcado
        /// </summary>
        public bool Automatico { get; set; }
        /// <summary>
        /// Campo para alguma informação adicional
        /// </summary>
        public string Obs { get; set; }

    }
}
