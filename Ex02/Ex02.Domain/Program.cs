using System;
using Ex02.Entities;
using System.Collections.Generic;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro l1 = new Livro("Harry Potter", 40, 50, "J. K. Rowling", "fantasia", 360);
            Livro l2 = new Livro("Senhor dos Anéis", 60, 30, "J. R. R. Tolkien", "fantasia", 500);
            Livro l3 = new Livro("JAVA POO", 20, 50, "GFT", "educativo", 500);

            VideoGame ps4 = new VideoGame("PS4", 1800, 100, "Sony", "Slim", false);
            VideoGame ps4Usado = new VideoGame("PS4", 1000, 7, "Sony", "Slim", true);
            VideoGame xbox = new VideoGame("XBOX", 1500, 500, "Microsoft", "One", false);

            List<Livro> livros = new List<Livro>();
            livros.Add(l1);
            livros.Add(l2);
            livros.Add(l3);

            List<VideoGame> games = new List<VideoGame>();
            games.Add(ps4);
            games.Add(ps4Usado);
            games.Add(xbox);

            double calculaPatrimônio = ((l1.Preco * l1.Qtd) + (l2.Preco * l2.Qtd) + (l3.Preco * l3.Qtd)
         + (ps4.Preco * ps4.Qtd) + (ps4Usado.Preco * ps4Usado.Qtd) + (xbox.Preco * xbox.Qtd));
           

            Loja americanas = new Loja("Americanas", "12345678", livros, games);

            l2.calculaImposto();
            l3.calculaImposto();

            ps4Usado.calculaImposto();
            ps4.calculaImposto();

            americanas.listaLivros();
            americanas.listaVideoGames();
            americanas.CalcularPatrimonio();

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Impostos sobre o livro Senhor dos Anéis: R$ " + l2.calculaImposto().ToString("F1"));
            Console.WriteLine("Livro Educativo não tem imposto: " + l3.Nome);
            Console.WriteLine("Imposto ps4 usado : R$ " + ps4Usado.calculaImposto().ToString("F1"));
            Console.WriteLine("Imposto ps4: R$ " + ps4.calculaImposto().ToString("F1"));
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("As Lojas Americanas possuem esses livros para vendas ");
            Console.WriteLine("Título " + l1.Nome + " Preço:" + l1.Preco.ToString("F1") + " Quantidade: " + l1.Qtd);
            Console.WriteLine("Título " + l2.Nome + " Preço:" + l2.Preco.ToString("F1") + " Quantidade: " + l2.Qtd);
            Console.WriteLine("Título " + l3.Nome + " Preço:" + l3.Preco.ToString("F1") + " Quantidade: " + l3.Qtd);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("As Lojas Americanas possuem esses videogames para vendas ");
            Console.WriteLine("VideoGame " + ps4.Nome + " Preço:" + ps4.Preco.ToString("F1") + " Quantidade: " + ps4.Qtd);
            Console.WriteLine("VideoGame " + ps4Usado.Nome + " Preço:" + ps4Usado.Preco.ToString("F1") + " Quantidade: " + ps4Usado.Qtd);
            Console.WriteLine("VideoGame " + xbox.Nome + " Preço:" + xbox.Preco.ToString("F1") + " Quantidade: " + xbox.Qtd);
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("O patrimônio das Lojas Americanas é: R$ " + calculaPatrimônio.ToString("F1"));

        }
    }
}
