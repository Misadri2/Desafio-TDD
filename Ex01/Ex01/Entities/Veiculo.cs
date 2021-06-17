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

        public Veiculo()
        {
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
             if (Velocidade == 0 || IsLigado == false)
                throw new ArgumentException("Não foi possível frear!");
            
            Velocidade -= 20;
        }
        
        public void Pintar(string Cor)
        {

        }

        public void ligar()
        {
            if (IsLigado == true)
                throw new ArgumentException("O carro já está ligado!");

            IsLigado = true;

        }
        public void desligar()
        {
            if (IsLigado != true)
            {
                throw new ArgumentException("O carro está desligado");
                
            }Console.WriteLine("Desligar veículo");
            
        }
    }
}
