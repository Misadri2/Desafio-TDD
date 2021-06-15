using System;

namespace Ex02.Entities
{
    public class Livro : Produto, IImposto
    {
       
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }

        public Livro()
        {

        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdpag)
        : base (nome, preco, qtd)
        {
            Autor = autor;
            Tema = tema;
            QtdPag = qtdpag;
        }        

        public double calculaImposto()
        {
            if (Preco < 1)
                throw new ArgumentException("Preço inválido para calcular imposto");
            if (Tema != "Educativo")
                return Preco *= 0.10;
            else
               return Preco;
        }
    }    
}