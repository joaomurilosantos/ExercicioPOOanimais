using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Cisne : Ave, IVoar, IAquatico, IOviparo
    {
        public Cisne(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, bool rapina, string corpena, int altitudemaximaemmetros,double velocidadedevoo, bool viveemterra, bool mergulho, bool aguadoce) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, rapina, corpena)
        {
            AltitudeMaximaEmMetros = altitudemaximaemmetros;
            VelocidadeDoVoo = velocidadedevoo;
            ViveEmTerra = viveemterra;
            Mergulho = mergulho;
            AguaDoce = aguadoce;
        }
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
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
        public void InformacoesAquatico()
        {
            Console.WriteLine("  Vive em terra? " + ViveEmTerra);
            Console.WriteLine("  Mergulho? " + Mergulho);
            Console.WriteLine("  Vive em agua doce? " + AguaDoce);
        }
        public void InformacoesVoar()
        {
            Console.WriteLine("  Velocidade do voo: " + VelocidadeDoVoo);
            Console.WriteLine("  Altitude Maxima (m): " + AltitudeMaximaEmMetros);
        }
    }
}
