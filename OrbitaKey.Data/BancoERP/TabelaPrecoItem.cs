using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    public class TabelaPrecoItem
    {
        public int Id { get; set; }
        public string Guid { get; set; }

        /// <summary>
        /// ID da tabela de preços
        /// </summary>
        public int TabelaId { get; set; }

        /// <summary>
        /// ID do item da nota que foi lançada
        /// </summary>
        public int? EntradaItemId { get; set; }
        /// <summary>
        /// Data da digitação
        /// </summary>
        public DateTime Data { get; set; }
        /// <summary>
        /// Data e hora que a aplicação foi realizada
        /// </summary>
        public DateTime? DataAplicacao { get; set; }
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
        /// ID Usuário que criou a tabela de preços
        /// </summary>
        public int UsuarioId { get; set; }
        /// <summary>
        /// Nome do usuário que criou a tabela de preços
        /// </summary>
        public string Usuario { get; set; }

        /// <summary>
        /// Indica se o produto ja teve seu preço revisado
        /// </summary>
        public bool Revisado { get; set; }
        /// <summary>
        /// Define se a aplicação foi já realizada
        /// </summary>
        public bool Aplicado { get; set; }

        /// <summary>
        /// Define se o produto será enviado para criação de etiqueta
        /// </summary>
        public bool Etiqueta { get; set; }
        /// <summary>
        /// Id Usuário que aplicou a alteração de preços
        /// </summary>
        public int? AplicadoUsuarioId { get; set; }
        /// <summary>
        /// Nome do usuário que aplicou a alteração de preços
        /// </summary>
        public string AplicadoUsuario { get; set; }
        /// <summary>
        /// Caso seja para o sistema aplicar o preço automaticamente no horário marcado
        /// </summary>
        public string Obs { get; set; }
        public int Codigo { get; set; }
        public string Barras { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }

        /// <summary>
        /// Ultimo custo unitario do produto, capturado pelo lnçamento da nota anterior
        /// </summary>
        public decimal Custo { get; set; }
        /// <summary>
        /// Custo uniário do produto, para casos em que houve a importação da nota para tabela de preços
        /// </summary>
        public decimal CustoNovo { get; set; }

        /// <summary>
        /// Adicional em valor sobre o valor do custo
        /// </summary>
        public decimal CustoAdicionalValor { get; set; }

        /// <summary>
        /// Adicional em percentual sobre o valor do custo
        /// </summary>
        public decimal CustoAdicionalPercentual { get; set; }


        /// <summary>
        /// Custo novo final
        /// </summary>
        public decimal CustoNovoFinal { get; set; }


        /// <summary>
        /// Preço atual do produto, que está no cadastro no momento
        /// </summary>
        public decimal Preco1 { get; set; }
        public decimal Preco2 { get; set; }
        public decimal Preco3 { get; set; }
        public decimal Preco4 { get; set; }
        public decimal Preco5 { get; set; }
        public decimal Preco6 { get; set; }

        /// <summary>
        /// Preço novo do produto, que será aplicado
        /// </summary>
        public decimal Preco1Novo { get; set; }
        public decimal Preco2Novo { get; set; }
        public decimal Preco3Novo { get; set; }
        public decimal Preco4Novo { get; set; }
        public decimal Preco5Novo { get; set; }
        public decimal Preco6Novo { get; set; }

        /// <summary>
        /// Margem aplicada sobre o custo para calcular o preço
        /// Usar para ajustar automaticamente no lançamento posterior
        /// </summary>
        public decimal Preco1Margem { get; set; }
        public decimal Preco2Margem { get; set; }
        public decimal Preco3Margem { get; set; }
        public decimal Preco4Margem { get; set; }
        public decimal Preco5Margem { get; set; }
        public decimal Preco6Margem { get; set; }
    }
}
