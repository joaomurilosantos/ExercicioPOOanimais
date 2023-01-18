using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Reptil : Animal
    {
        public Reptil(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, bool temescamas, bool temcasco) : base(nome,datadenascimento,sexo,idade,peconhento,carnivoro)
        {
            TemEscamas = temescamas;
            TemCasco = temcasco;
        }
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }

        public void InformacoesReptil()
        {
            Console.WriteLine("  Tem escamas? " + TemEscamas);
            Console.WriteLine("  Tem casco? " + TemCasco);
        }

    }
}
