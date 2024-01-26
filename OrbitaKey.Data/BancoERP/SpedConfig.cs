namespace OrbitaKey.Data.BancoERP
{
    public partial class SpedConfig
    {
        public int Id { get; set; }
        public int IdEmpresa { get; set; }

        /// <summary>
        /// Indicador de tipo de atividade:
        /// 0 – Industrial ou equiparado a industrial;
        /// 1 – Outros
        /// </summary>
        public int IndAtiv { get; set; }
        /// <summary>
        /// Perfil de apresentação do arquivo fiscal;
        /// A – Perfil A;
        /// B – Perfil B.;
        /// C – Perfil C.
        /// </summary>
        public int IndPerfil { get; set; }

        /// <summary>
        /// COD VERSÃO SPED FISCAL
        /// </summary>
        public int CodigoVersao { get; set; }

        /// <summary>
        /// COD VERSÃO SPED FISCAL
        /// </summary>
        public int CodigoVersaoContribuicoes { get; set; }

        /// <summary>
        /// Código de receita referente à obrigação, próprio da unidade da federação, conforme legislação estadual. E116 - 5
        /// </summary>
        public string CodigoReceita { get; set; }
        /// <summary>
        /// Data de vencimento da obrigação. Dia para pagamento do imposto. E116 - 4
        /// </summary>
        public int DataImposto { get; set; }
        /// <summary>
        /// Código da obrigação a recolher, conforme a Tabela 5.4. E116 - 2
        /// </summary>
        public string CodigoObrigacao { get; set; }

        /// <summary>
        /// Código indicador da incidência tributária no período
        /// 1 – Escrituração de operações com incidência exclusivamente no regime não - cumulativo;
        /// 2 – Escrituração de operações com incidência exclusivamente no regime cumulativo;
        /// 3 – Escrituração de operações com incidência nos regimes não-cumulativo e cumulativo*/
        /// </summary>
        public int IncidenciaTributaria { get; set; }
    }
}
