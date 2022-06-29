using System;
using _10__Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_Sharp.src.Entities;

namespace _10__Abstraindo_um_Jogo_de_RPG_Usando_Orientação_a_Objetos_com_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando de fato o heroi instansciado em Arus
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            Wizard topapa = new Wizard("Topapa", 30, "Black Wizard");
            Ninja wedge = new Ninja("Wedge", 35, "Ninja");
            

            Console.WriteLine(arus);
            Console.WriteLine(jennica);
            Console.WriteLine(wedge);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(1));
            Console.WriteLine(jennica.Attack(7));
            Console.WriteLine(wedge.Attack());
        }
    }
}

            /*
            METODO ESTRUTURAL DE REPRESENTAR UM OBJETO
            string nome = "Arus";
            int level = 12;
            string tipoHeroi = "Guerreiro";

            string nome2 = "Wedge";
            int level2 = 20;
            string tipoHeroi2 = "Ninja";

            Console.WriteLine(nome + " " + level + " " + tipoHeroi);
            Console.WriteLine(nome2 + " " + level2 + " " + tipoHeroi2);
            */
