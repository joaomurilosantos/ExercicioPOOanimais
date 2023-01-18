using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class DragaoDeComodo : Reptil, IAquatico, IOviparo
    {
        public DragaoDeComodo(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, bool temescamas, bool temcasco, bool viveemterra, bool mergulho, bool aguadoce) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, temescamas, temcasco)
        {
            ViveEmTerra = viveemterra;
            Mergulho = mergulho;
            AguaDoce = aguadoce;
        }
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
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

    }
}
