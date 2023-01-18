using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinoAnimal
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Arara arara = new Arara("Arara", new DateTime(2002, 12, 23), 'M', 20, false, false, false, "Azul", 100, 50);
            arara.InformacoesAnimal();
            arara.InformacoesAve();
            arara.InformacoesVoar();
            Console.WriteLine("==========================");

            Chacal chacal = new Chacal("Chacal", new DateTime(2021, 03, 21), 'F', 1, false, true, 8, true, "Marrom");
            chacal.InformacoesAnimal();
            chacal.InformacoesMamifero();
            Console.WriteLine("==========================");

            Cisne cisne = new Cisne("Cisne", new DateTime(2020, 01, 01), 'F', 2, false, false, false, "Branca", 10, 46, true, false, true);
            cisne.InformacoesAnimal();
            cisne.InformacoesAve();
            cisne.InformacoesAquatico();
            cisne.InformacoesVoar();
            Console.WriteLine("==========================");

            Coruja coruja = new Coruja("Coruja", new DateTime(2010, 01, 31), 'M', 12, false, true, false, "Branca", 70, 150);
            coruja.InformacoesAnimal();
            coruja.InformacoesAve();
            coruja.InformacoesVoar();
            Console.WriteLine("==========================");

            DragaoDeComodo dragaodecomodo = new DragaoDeComodo("Dragao de comodo", new DateTime(2013, 10, 28), 'M', 9, true, true, true, false, true, true, true);
            dragaodecomodo.InformacoesAnimal();
            dragaodecomodo.InformacoesReptil();
            dragaodecomodo.InformacoesAquatico();          
            Console.WriteLine("==========================");

            Elefante elefante = new Elefante("Elefante", new DateTime(2015, 12, 27), 'F', 17, false, false, 6, true, "preto");
            elefante.InformacoesAnimal();
            elefante.InformacoesAnimal();
            Console.WriteLine("==========================");

            Jacare jacare = new Jacare("Jacare", new DateTime(2017, 12, 23), 'M', 5, false, true, true, false, true, true, true);
            jacare.InformacoesAnimal();
            jacare.InformacoesReptil();
            jacare.InformacoesAquatico();
            Console.WriteLine("==========================");

            Leao leao = new Leao("Leao", new DateTime(2018, 04, 12), 'M', 4, false, true, 6, true, "Amarelo");
            leao.InformacoesAnimal();
            leao.InformacoesMamifero();
            Console.WriteLine("==========================");

            Lontra lontra = new Lontra("Lontra", new DateTime(2016, 05, 09), 'F', 6, false, true, 8, true, "Marrom", false, true, true);
            lontra.InformacoesAnimal();
            lontra.InformacoesMamifero();
            lontra.InformacoesAquatico();
            Console.WriteLine("==========================");

            Morcego morcego = new Morcego("Morcego", new DateTime(2002, 12, 23), 'F', 20, false, true, 6, true, "Preto", 59, 120);
            morcego.InformacoesAnimal();
            morcego.InformacoesMamifero();
            morcego.InformacoesVoar();
            Console.WriteLine("==========================");

            Ornitorrinco ornitorrinco = new Ornitorrinco("Ornitorrinco", new DateTime(2018, 04, 12), 'M', 4, true, true, 6, true, "Marrom", false, true, true);
            ornitorrinco.InformacoesAnimal();
            ornitorrinco.InformacoesMamifero();
            ornitorrinco.InformacoesAquatico();
            Console.WriteLine("==========================");

            Pinguim pinguim = new Pinguim("Pinguim", new DateTime(2021, 03, 21), 'M', 1, false, false, false, "Preta", true, true, false);
            pinguim.InformacoesAnimal();
            pinguim.InformacoesAve();
            pinguim.InformacoesAquatico();
            Console.WriteLine("==========================");

        }
    }











}

