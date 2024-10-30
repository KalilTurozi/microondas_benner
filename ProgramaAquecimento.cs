using System;

namespace MicroondasDigital
{
    public abstract class ProgramaAquecimento
    {
        public string Nome { get; set; }
        public string Alimento { get; set; }
        public TimeSpan Tempo { get; protected set; }
        public int Potencia { get; protected set; }
        public char CaractereAquecimento { get; set; }
        public string Instrucoes { get; set; }

        public ProgramaAquecimento(string nome, string alimento, TimeSpan tempo, int potencia, char caractereAquecimento, string instrucoes = "")
        {
            Nome = nome;
            Alimento = alimento;
            Tempo = tempo;
            Potencia = potencia;
            CaractereAquecimento = caractereAquecimento;
            Instrucoes = instrucoes;
        }

        public abstract void Iniciar();
    }
}