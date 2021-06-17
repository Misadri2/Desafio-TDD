using Xunit;
using System;
using Ex01.Entities;


namespace Ex01.Tests.Teste
{
    public class TesteVeiculo
    {
        [Fact]
        public void Deve_criar_veiculo()
        {
            var veiculo = new Veiculo();
            Assert.NotNull(veiculo);
        }

        [Fact]
        public void Deve_desligar_veiculo()
        {
            var veiculo = new Veiculo();
            Assert.Throws<ArgumentException>(() => veiculo.desligar());
        }

        [Fact]
        public void Deve_frear_veiculo()
        {
            var veiculo = new Veiculo();
            Assert.Throws<ArgumentException>(() => veiculo.Frear());
        }


        [Theory]           // Represents a suite of tests that execute the same code but have different input arguments.
        [InlineData(70)]  //Attribute specifies values for those inputs.
        [InlineData(100)]
        [InlineData(1000)]
        public void Nao_deve_abastecer_veiculo_acima_do_limite_de_combustivel(int limiteCombustivelInvalido)
        {
            var veiculo = new Veiculo(limiteCombustivelInvalido);

            Assert.Throws<ArgumentException>(() => veiculo.Abastecer(limiteCombustivelInvalido));

        }
    }
}