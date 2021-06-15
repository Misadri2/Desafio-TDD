using System;

namespace Jokenpo.Domain
{
    public class Program
    {
        static void Main(string[] args)
        {
            NovoJogo();
        }

        private static void NovoJogo()
        {
            Console.WriteLine("Escolha um número que represente uma das seguintes opções:");
            Console.WriteLine("*************************************");
            Console.WriteLine(" 1 - Pedra");
            Console.WriteLine(" 2 - Papel");
            Console.WriteLine(" 3 - Tesoura");
            Console.WriteLine(" 0 - Sair do jogo");
            Console.WriteLine("**************************************");

            Console.Write("Jogador 1: ");
            var jogada1 = ValidarJogada();

            Console.Write("Jogador 2: ");
            var jogada2 = ValidarJogada();

            var resultado = CalcularJogada(jogada1, jogada2);

            ExibirResultado(jogada1, jogada2, resultado);

            FimDeJogo();
        }

        public static int CalcularJogada(int jogada1, int jogada2)
        {

            if (jogada1 % 3 + 1 == jogada2)
                return jogada2;

            else if (jogada2 % 3 + 1 == jogada1)
                return jogada1;

            else
                return 0;
        }

        private static void ExibirResultado(int jogada1, int jogada2, int resultado)
        {
            var msg = string.Empty;

            if (resultado == jogada1)
                msg = "Jogador 1 ganhou!";

            else if (resultado == jogada2)
                msg = "Jogador 2 ganhou!";

            else
                msg = "Empate";

            Console.WriteLine();
            Console.WriteLine($"Resultado: {msg}");
        }

        private static int ValidarJogada()
        {
            var resultado = 0;
            var jogada = Console.ReadLine();

            if (jogada == "0")
                Environment.Exit(0);

            else if (!int.TryParse(jogada, out resultado) || (resultado < 1 || resultado > 3))
            {
                JogadaInvalida();
                NovoJogo();
            }

            return resultado;
        }

        public static void JogadaInvalida()
        {
            Console.WriteLine("Jogada inválida");
            Console.ReadKey();
            Console.Clear();
        }
        private static void FimDeJogo()
        {
            Console.WriteLine();
            Console.WriteLine("Fim de jogo");
        }

    }
}