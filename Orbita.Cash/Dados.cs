namespace Orbita.Cash
{
    public static class Dados
    {
        public static string Cnpj { get; set; } = "24165835000160";
        public static OrbitaKey.Data.Models.Empresa Empresa { get; set; } = new OrbitaKey.Data.Models.Empresa();
        public static OrbitaKey.Data.Models.Cliente Cliente { get; set; } = new OrbitaKey.Data.Models.Cliente();
        public static OrbitaKey.Data.Models.CashConfig Config { get; set; } = new OrbitaKey.Data.Models.CashConfig();
    }
}
