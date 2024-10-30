using System;

namespace MicroondasDigital
{
    public class ProgramaAquecimentoCustomizado : ProgramaAquecimento
    {
        public ProgramaAquecimentoCustomizado(string nome, string alimento, TimeSpan tempo, int potencia, char caractereAquecimento, string instrucoes = "")
            : base(nome, alimento, tempo, potencia, caractereAquecimento, instrucoes)
        {
        }

        public override void Iniciar()
        {
            // iniciar programa customizado
        }
    }
}