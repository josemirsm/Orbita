using System.Diagnostics;

namespace Orbita.Cash
{
    public static class Util
    {
        public static string CapturarVersao()
        {
            string versao = string.Empty;

            try
            {
                string caminhoExecutavel = Process.GetCurrentProcess().MainModule.FileName;
                FileVersionInfo versaoArquivo = FileVersionInfo.GetVersionInfo(caminhoExecutavel);
                versao = $"v{versaoArquivo.FileVersion}";
            }
            catch (Exception) { }

            return versao;
        }
    }
}
