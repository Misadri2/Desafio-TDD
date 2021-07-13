using System;
using System.Collections.Generic;
using FizzBuzz.Domain.Entities;

namespace FizzBuzz.Domain
{
    class Program
    {
        //Divisível por 3 => Fizz
        //Divisível por 5 => Buzz
        //Divisível por 3 e 5 => FizzBuzz
        //Não divisível por 3 e 5 => entrada
        // Qualquer string => NaN
        static void Main(string[] args)
        {
            //Resolução oficial enviada para Gitlab
            List<string> Numeros = new List<string>();

            var fizzBuzz = new FBProgram(Numeros);

            fizzBuzz.Executar(Numeros);
            fizzBuzz.Listar(Numeros); 


            //Resolução 2
            /* var word = "fizz";
            var word1 = "buzz";
            var word2 = "fizzbuzz";
            var count = 100;

            while (count > 0)
            {
                count = count - 1;

                if (count % 3 == 0)
                {
                    Console.WriteLine(word);
                }
                if (count % 5 == 0)
                {
                    Console.WriteLine(word1);
                }
                if (count % 5 == 0 && count % 3 == 0)
                {
                    Console.WriteLine(word2);
                }
                if (count % 5 != 0 && count % 3 != 0)
                {
                    Console.WriteLine(count);
                } 
                
            } */
        }
    }
}

