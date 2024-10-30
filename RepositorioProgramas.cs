using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace MicroondasDigital
{
    public class RepositorioProgramas
    {
        private readonly string caminhoArquivoJson = "programasCustomizados.json";

        public List<ProgramaAquecimentoCustomizado> CarregarProgramasCustomizados()
        {
            if (!File.Exists(caminhoArquivoJson))
                return new List<ProgramaAquecimentoCustomizado>();

            var json = File.ReadAllText(caminhoArquivoJson);
            return JsonConvert.DeserializeObject<List<ProgramaAquecimentoCustomizado>>(json);
        }

        public void SalvarProgramasCustomizados(List<ProgramaAquecimentoCustomizado> programas)
        {
            var json = JsonConvert.SerializeObject(programas, Formatting.Indented);
            File.WriteAllText(caminhoArquivoJson, json);
        }
    }
}