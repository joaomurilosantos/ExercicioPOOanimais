using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Lontra : Mamifero, IAquatico
    {
        public Lontra(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, int quantmamas, bool pelos, string cordospelos, bool viveemterra, bool mergulho, bool aguadoce) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, quantmamas, pelos, cordospelos)
        {
            ViveEmTerra = viveemterra;
            Mergulho = mergulho;
            AguaDoce = aguadoce;
        }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public void InformacoesAquatico()
        {
            Console.WriteLine("  Vive em terra? " + ViveEmTerra);
            Console.WriteLine("  Mergulho? " + Mergulho);
            Console.WriteLine("  Vive em agua doce? " + AguaDoce);
        }
    }
}
