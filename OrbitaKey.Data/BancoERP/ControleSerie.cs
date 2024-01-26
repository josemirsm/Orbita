
using System;

namespace OrbitaKey.Data.BancoERP
{
    public partial class ControleSerie
    {
        public int Id { get; set; }
        public bool Baixado { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public string Lote { get; set; }
        public string Serie1 { get; set; }
        public string Serie2 { get; set; }
        public string UsuarioAtualizacao { get; set; }
        public DateTime? DataDaBaixa { get; set; }
        public DateTime DataDeCadastro { get; set; }
    }
}
