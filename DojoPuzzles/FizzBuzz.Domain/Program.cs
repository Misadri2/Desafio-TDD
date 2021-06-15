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
            List<string> Numeros = new List<string>();

            var fizzBuzz = new FBProgram(Numeros);

            fizzBuzz.Executar(Numeros);
            fizzBuzz.Listar(Numeros);
            
        }
    }
}
