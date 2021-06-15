using FizzBuzz.Domain.Entities;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Testes.Domain
{
    public class FBProgramTestes
    {
        [Fact]
        public void Deve_criar_um_fizz_buzz()
        {
            List<string> lista = new List<string>();

            var fizz = new FBProgram(lista);

            Assert.NotNull(fizz);
        }

        [Fact]
        public void Deve_executar_se_tamanho_lista_valido()
        {
            List<string> lista = new List<string>();

            var fizz = new FBProgram(lista);

            fizz.Executar(lista);
            Assert.True(lista.Count <= 100);
        }

        [Fact]
        public void Deve_verificar_tamanho_lista_correto()
        {
            List<string> lista = new List<string>();

            var fizz = new FBProgram(lista);

            fizz.Listar(lista);
            Assert.True(lista.Count <= 100);
        }
    }
}

