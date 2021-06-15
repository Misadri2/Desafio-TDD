using System;
using System.Collections.Generic;

namespace Ex03.Entities

{
    public class Mago : Personagem
    {
        public List<string> Magia { get; set; }
        public Mago(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        public Mago()
        {
        }

        public override void lvlUp()
        {
            Level++;
            Mana += 1;
            Inteligencia += 5;
        }
        public void attack(double ataque)
        {
            Random rd = new Random();
            int num = rd.Next(300);
            ataque = (Forca * Level) + num;
        }
        public string aprenderMagia(string magia)
        {
            Magia.Add(magia);
            return magia;
        }


    }
}