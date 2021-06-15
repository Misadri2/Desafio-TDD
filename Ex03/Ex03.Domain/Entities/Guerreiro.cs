using System;
using System.Collections.Generic;
namespace Ex03.Entities
{
        public class Guerreiro : Personagem
    {

        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
        : base(nome, vida, mana, xp, inteligencia, forca, level)
        {
        }

        public Guerreiro()
        {
        }

        public List<string> Habilidade {get; set;} 
       
        public override void lvlUp()
        {
                Level++;
                Vida+=1;
                Forca +=5;
        }
        public void attack(double ataque)
        {
            Random rd = new Random();
            int num = rd.Next(300);
            ataque = (Forca * Level) + num;        }
        public string aprenderHabilidade(string habilidade)
        {
            Habilidade.Add(habilidade);
            return habilidade;
        }
    }
}