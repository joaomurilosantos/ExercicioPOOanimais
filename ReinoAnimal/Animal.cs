using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public abstract class Animal
    {
        public Animal(string nome, DateTime datadenascimento, char sexo, int idade, bool peconhento, bool carnivoro)
        {
            Nome = nome;
            DataDeNascimento = datadenascimento;
            Sexo = sexo;
            Idade = idade;
            Peconhento = peconhento;
            Carnivoro = carnivoro;
        }

        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public bool Peconhento { get; set; }        
        public bool Carnivoro { get; set; }

        public void Movimentar()
        {
            Console.WriteLine($"{this.Nome}, está se movimentando.");
        }

        public void Comunicar()
        {
            Console.WriteLine($"{this.Nome}, está se comunicando.");
        }

        public void Alimentar()
        {
            Console.WriteLine($"{this.Nome}, está se alimentando.");
        }

        public void InformacoesAnimal()
        {
            Console.WriteLine("  Nome: " + Nome);
            Console.WriteLine("  Data de nascimento: " + DataDeNascimento);
            Console.WriteLine("  Sexo: " + Sexo);
            Console.WriteLine("  Idade: " + Idade);
            Console.WriteLine("  Peconhento: " + Peconhento);
            Console.WriteLine("  Carnivoro: " + Carnivoro);
        }
    }
}
