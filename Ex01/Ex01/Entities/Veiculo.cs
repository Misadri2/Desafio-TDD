using System;

namespace Ex01.Entities
{
    public class Veiculo
    {
        private bool isLigadoFalse;
        private int limiteCombustivelInvalido;

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public Boolean IsLigado { get; set; }
        public int LitrosCombustível { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo()
        {

        }
        public Veiculo(string marca, string modelo, string placa, string cor, float km, Boolean isligado, int litroscombustivel, int velocidade, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = isligado;
            LitrosCombustível = litroscombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }

        public Veiculo(int limiteCombustivelInvalido)
        {
            this.limiteCombustivelInvalido = limiteCombustivelInvalido;
        }

        public void Acelerar() => Velocidade += 20;
        public void Abastecer(int combustivel)
        {
            if (combustivel > 60)
                throw new ArgumentException("Excedeu o limite da quantidade de combustível");

            LitrosCombustível = combustivel;
            Console.WriteLine(("Abastecido"));
        }

        public void Frear()
        {
            if (Velocidade == 0)
                Console.WriteLine("Veículo está parado");
            else
                Velocidade -= 20;
        }
        public void Pintar(string Cor)
        {

        }

        public void ligar()
        {
            if (IsLigado == false)
            {
                Console.WriteLine("Ligar veículo");
            }
            else
            {
                Console.WriteLine("Veículo está ligado");
            }

        }
        public void desligar()
        {
            if (IsLigado == true)
            {
                Console.WriteLine("Desligar veículo");
            }
            else
            {
                Console.WriteLine("Veículo está desligado");
            }
        }
    }
}
