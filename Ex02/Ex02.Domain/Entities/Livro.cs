using System;

namespace Ex02.Entities
{
    class Livro : Produto, IImposto
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
        public double calculaImposto(double Preco)
        {
            if (Tema == "Educativo")
                return Preco * 0.0;
            else
               return Preco * 0.10;
        }

        public double calculaImposto()
        {
            if (Tema == "Educativo")
                return Preco * 0.0;
            else
               return Preco * 0.10;
        }
    }    
}