using System;
using System.Collections.Generic;
using Ex03.Entities;

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Guerreiro> guerreiros = new List<Guerreiro>();
            List<Mago> magos = new List<Mago>();
            Guerreiro guerreiro1 = new Guerreiro();
            Mago mago1 = new Mago();

            Console.Write("Digite o nome do guerreiro: ");
            guerreiro1.Nome = Console.ReadLine();
            Console.Write("Digite o nome do mago: ");
            mago1.Nome = Console.ReadLine();
            

            mago1.lvlUp();
            guerreiro1.lvlUp();
            guerreiros.Add(guerreiro1);
            magos.Add(mago1);
            int countGuerreiro = 0;
            foreach (Personagem item in guerreiros)
            {
                countGuerreiro++;
            }
            int countMago = 0;
            foreach (Personagem item in magos)
            {
                countMago++;
            }
            int somaCount = countGuerreiro + countMago;

            Console.WriteLine("****************************************");
            Console.WriteLine("Nome guerreiro: "+ guerreiro1.Nome);       
            Console.WriteLine("Level guerreiro: " + guerreiro1.Level);           
            Console.WriteLine("****************************************");
            Console.WriteLine("Nome mago: " + mago1.Nome);         
            Console.WriteLine("Level mago: " + mago1.Level);
            Console.WriteLine("****************************************");
            Console.WriteLine("Qtd de personagens: " + somaCount);
            

        }
    }
}
