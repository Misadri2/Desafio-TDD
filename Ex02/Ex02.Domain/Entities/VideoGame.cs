using System;

namespace Ex02.Entities
{
    class VideoGame : Produto, IImposto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Boolean IsUsado { get; set; }

        public VideoGame()
        {

        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, Boolean isUsado)
        : base(nome, preco, qtd)
        {
            Marca = marca;
            Modelo = modelo;
            IsUsado = isUsado;
        }

        public double calculaImposto(double Preco)
        {
            if (IsUsado)
                return Preco * 0.25;
            else
                return Preco * 0.45;
        }

        public double calculaImposto()
        {
            if (IsUsado)
                return Preco * 0.25;
            else
                return Preco * 0.45;
        }
    }
}