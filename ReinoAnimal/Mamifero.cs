using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Mamifero : Animal
    {
        public Mamifero(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, int quantmamas, bool pelos, string cordospelos) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro)
        {
            QuantMamas = quantmamas;
            Pelos = pelos;
            CorDosPelos = cordospelos;
        }
        
        public int QuantMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDosPelos { get; set; }

        public void Amamentar()
        {
            Console.WriteLine($"{Nome}, está amamentando.");
        }

        public void InformacoesMamifero()
        {
            Console.WriteLine("  Quantidade de mamas: " + QuantMamas);
            Console.WriteLine("  Possui pelos? " + Pelos);
            Console.WriteLine("  Cor dos pelos: " + CorDosPelos);
        }
    }
}
