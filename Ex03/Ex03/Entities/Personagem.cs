namespace Ex03.Entities
{
      public abstract class Personagem
    {
        public string Nome { get ; set; }
        public int Vida { get; set; }
        public int Mana { get; set; }
        public float Xp { get; set; }
        public int Inteligencia { get; set; }
        public int Forca { get; set; }
        public int Level { get; set; }

        public Personagem()
        {

        }

        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
        {
        }

        public virtual void lvlUp ()
        {

        }
    }
}