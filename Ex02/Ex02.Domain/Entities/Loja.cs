using System;
using System.Collections.Generic;



namespace Ex02.Entities
{
    class Loja
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public List<Livro> Livros { get; set; } 
        public List<VideoGame> VideoGames { get; set; } 

        public Loja()
        {

        }
        public Loja(string nome, string cnpj, List<Livro> livros, List<VideoGame> videogames)
        {
            Nome = nome;
            CNPJ = cnpj;
            List<Livro> Livros = livros;
            List<VideoGame> VideoGames = videogames;
        }

        public void listaLivros()
        {   
            Livros = new List<Livro>();
            foreach (Livro lista in Livros)
            if (Livros.Count == 0)
            {
                Console.WriteLine("A loja não tem livros em seu estoque");
            }
            
        }

        public void listaVideoGames()
        {
            VideoGames = new List<VideoGame>();
            foreach (VideoGame list in VideoGames)
            if (VideoGames.Count == 0)
            {
                Console.WriteLine("A loja não tem Video-Games em seu estoque");
            }

            
        }

        public double CalcularPatrimonio()
        {
            double calculoLivro = 0;
            double calculoVideoGame = 0;

            List<Livro> livro = new List<Livro>();
            foreach (var list in livro) {
                calculoLivro = list.Preco * list.Qtd;
            } 

            List<VideoGame> game = new List<VideoGame>();
            foreach (var videogame in game) {
                calculoVideoGame = videogame.Preco * videogame.Qtd;
            }
            double calculoTotal;
            return  calculoTotal = calculoVideoGame + calculoLivro;           
                        
        }
    }
}
