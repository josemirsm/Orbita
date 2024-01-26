using System;
using System.Collections.Generic;

namespace OrbitaKey.Data.BancoERP
{
    public partial class Transportador
    {
        public int Id { get; set; }
        public bool? Ativo { get; set; }
        public decimal? Capacidade { get; set; }
        public string Carroceria { get; set; }
        public string Descricao { get; set; }
        public bool? Excluido { get; set; }
        public int? IdVendedor { get; set; }
        public string Obs { get; set; }
        public string Placa { get; set; }
        public string PropCpfCnpj { get; set; }
        public string PropIe { get; set; }
        public string PropTipo { get; set; }
        public string PropUf { get; set; }
        public string Proprietario { get; set; }
        public string Renavam { get; set; }
        public string Responsavel { get; set; }
        public string Rntrc { get; set; }
        public string Rodado { get; set; }
        public decimal? Tara { get; set; }
        public bool? Terceiro { get; set; }
        public string Uf { get; set; }
        public string Motorista { get; set; }
        public string Cpf { get; set; }
    }
}
