using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Coruja : Ave, IVoar, IOviparo
    {
        public Coruja(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, bool rapina, string corpena, double velocidadedevoo, int altitudemaximaemmetros) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, rapina, corpena)
        {
            VelocidadeDoVoo = velocidadedevoo;
            AltitudeMaximaEmMetros = altitudemaximaemmetros;
        }
        public double VelocidadeDoVoo { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }
        public void Voar()
        {
            Console.WriteLine($"{this.Nome}, está voando.");
        }
        public void Botar()
        {
            Console.WriteLine($"{this.Nome}, está botando ovos.");
        }
        public void Chocar()
        {
            Console.WriteLine($"{this.Nome}, está chocando ovos.");
        }

        public void InformacoesVoar()
        {
            Console.WriteLine("  Velocidade do voo: " + VelocidadeDoVoo);
            Console.WriteLine("  Altitude Maxima (m): " + AltitudeMaximaEmMetros);
        }
    }
}
