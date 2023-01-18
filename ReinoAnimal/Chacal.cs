using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Chacal : Mamifero
    {
        public Chacal(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro, int quantmamas, bool pelos, string cordospelos) : base(nome, datadenascimento, sexo, idade, peconhento, carnivoro, quantmamas, pelos, cordospelos) {}
    }
}
