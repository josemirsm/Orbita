using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrbitaKey.Data.BancoERP
{
    /// <summary>
    /// Tabela de configurações dos aplicativos, favor seguir o prefixo
    /// Vex = Venda Externa
    /// Com = Comandas
    /// </summary>
    public partial class ConfigApp
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public bool VexExibirEstoque { get; set; }

        /// <summary>
        /// Exibe uma tela com os grupos antes da seleção dos itens
        /// </summary>
        public bool ComTelaGrupoAtiva { get; set; }

        /// <summary>
        /// Define se apenas que fez a abertura da comanda pode inserir produtos na mesa
        /// </summary>
        public bool ComRestricaoProdutosMesa { get; set; }
    }
}
