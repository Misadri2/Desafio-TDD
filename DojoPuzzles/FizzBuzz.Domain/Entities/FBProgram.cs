using System;
using System.Collections.Generic;

namespace FizzBuzz.Domain.Entities
{
    public class FBProgram
    {
        //Divisível por 3 => Fizz
        //Divisível por 5 => Buzz
        //Divisível por 3 e 5 => FizzBuzz
        //Não divisível por 3 e 5 => entrada
        // Qualquer string => NaN

        public List<string> Lista { get; set; }

        public FBProgram(List<string> lista)
        {
            Lista = lista;
        }

        public void Executar(List<string> Numeros)
        {
            int m = 0;

            for (int i = 1; i <= 100; i++)
            {
                Numeros.Add(i.ToString());

                if (i % 3 == 0)
                {
                    Numeros[m] = "Fizz";
                }

                if (i % 5 == 0)
                {
                    Numeros[m] = "Buzz";
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Numeros[m] = "FizzBuzz";
                }

                m++;
            }
        }
        public void Listar(List<string> Numeros)
        {
            for (int i = 0; i < Numeros.Count; i++)
            {
                Console.WriteLine(Numeros[i]);
            }
        }
    }
}