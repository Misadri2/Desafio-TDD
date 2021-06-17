using Jokenpo.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jokenpo.Tests.Domain
{
    [TestClass]
    public class ProgramTest
    {

        /* {1}Pedra, {2}Papel, {3}Tesoura */

        [TestMethod]
        [TestCategory("Domain")]
        public void Jogadas_Iguais_Empate()
        {
            var jogada1 = 1;
            var jogada2 = 1;
            var resultado = Program.CalcularJogada(jogada1, jogada2);
            Assert.AreEqual(0, resultado);

        }

        [TestMethod]
        [TestCategory("Domain")]
        public void PedraVSPapel_Papel_Deve_Vencer()
        {
            var jogada1 = 1;
            var jogada2 = 2;
            var resultado = Program.CalcularJogada(jogada1, jogada2);
            Assert.AreEqual(2, resultado);

        }

        [TestMethod]
        [TestCategory("Domain")]
        public void TesouraVSPapel_Tesoura_Deve_Vencer()
        {
            var jogada1 = 3;
            var jogada2 = 2;
            var resultado = Program.CalcularJogada(jogada1, jogada2);
            Assert.AreEqual(3, resultado);

        }

        [TestMethod]
        [TestCategory("Domain")]
        public void TesouraVSPedra_Pedra_Deve_Vencer()
        {
            var jogada1 = 1;
            var jogada2 = 3;
            var resultado = Program.CalcularJogada(jogada1, jogada2);
            Assert.AreEqual(1, resultado);

        } 

        [TestMethod]
        [TestCategory("Domain")]
        public void Não_Deve_Aceitar_Número_Nulo()
        {
            var jogada1 = 9;
            var jogada2 = 5;
            var resultado = Program.CalcularJogada(jogada1, jogada2);
            Assert.AreEqual(0, resultado);

        }                     
    }
}
