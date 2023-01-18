using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Morcego : Mamifero, IVoar
    {
        public Morcego(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, int quantmamas, bool pelos, string cordospelos, double velocidadedovoo, int altitudemaximaemmetros) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, quantmamas, pelos, cordospelos)
        {
            VelocidadeDoVoo = velocidadedovoo;
            AltitudeMaximaEmMetros = altitudemaximaemmetros;
        }
        public double VelocidadeDoVoo { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }
        public void Voar()
        {
            Console.WriteLine($"{this.Nome}, está voando.");
        }
        public void InformacoesVoar()
        {
            Console.WriteLine("  Velocidade do voo: " + VelocidadeDoVoo);
            Console.WriteLine("  Altitude Maxima (m): " + AltitudeMaximaEmMetros);
        }
    }
}
