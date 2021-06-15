using System;
using Ex01.Entities;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo carro = new Veiculo();

            Console.Write("Informe a marca do carro: ");
            carro.Marca = Console.ReadLine();
            Console.Write("Informe o modelo do carro: ");
            carro.Modelo = Console.ReadLine();
            Console.Write("Informe a placa do carro: ");
            carro.Placa = Console.ReadLine();
            Console.Write("Informe a cor do carro: ");
            carro.Cor = Console.ReadLine();
            Console.Write("Informe a quilometragem do carro: ");
            carro.Km = float.Parse(Console.ReadLine());
            Console.Write("Informe o preço do carro: ");
            carro.Preco = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Escolha um número de 1 a 6: 1- Ligar / 2 - Acelerar / 3 - Abastecer / 4 - Frear/ 5 - Pintar / 6 - Desligar");
            int resposta = int.Parse(Console.ReadLine());
            switch (resposta)
            {
                case 1:
                    carro.ligar();
                    Console.WriteLine("Você ligou o carro");
                    break;
                case 2:
                    carro.Acelerar();
                    Console.WriteLine("Você acelerou em 20km o carro");
                    break;
                case 3:
                    Console.Write("Com quantos litros você quer abastecer (limite 60l)");
                    int combustivel = int.Parse(Console.ReadLine());
                    carro.Abastecer(combustivel);
                    break;
                case 4:
                    carro.Frear();
                    Console.WriteLine("Você freou o carro");
                    break;
                case 5:
                    Console.Write("Digite uma cor: " );
                    string cor = Console.ReadLine();
                    carro.Pintar(cor);
                    Console.WriteLine("Cor do carro agora é: " + cor);
                    break;
                case 6:
                    carro.desligar();
                    Console.WriteLine("Você desligou o carro");
                    break;
                default:
                    Console.WriteLine("Sistema Encerrado");
                    break;
            }
        }
    }

}
    

