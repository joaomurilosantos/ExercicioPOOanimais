using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Ave : Animal
    {
        public Ave(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, bool rapina, string corpena) : base(nome,datadenascimento,sexo,idade,peconhento,carnivoro)
        {
            Rapina = rapina;
            CorPena = corpena;
        }
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine($"{Nome}, está ciscando.");
        }

        public void InformacoesAve()
        {
            Console.WriteLine("  Ave de rapina? " + Rapina);
            Console.WriteLine("  Cor da pena: " + CorPena);
        }
    }
}
