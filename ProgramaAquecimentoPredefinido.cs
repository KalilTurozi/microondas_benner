using System;

namespace MicroondasDigital
{
    public class ProgramaAquecimentoPredefinido : ProgramaAquecimento
    {
        public ProgramaAquecimentoPredefinido(string nome, string alimento, TimeSpan tempo, int potencia, char caractereAquecimento, string instrucoes)
            : base(nome, alimento, tempo, potencia, caractereAquecimento, instrucoes)
        {
        }

        public override void Iniciar()
        {
            // iniciar programa predefinido
        }
    }
}