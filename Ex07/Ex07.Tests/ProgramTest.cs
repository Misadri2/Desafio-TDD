using System;
using Xunit;
using Ex07.Entities;

namespace Ex07.Tests
{
    public class ProgramTest
    {
        private readonly string _nome;
        private readonly int _idade;
        private readonly double _salario;      

        public ProgramTest()
        {
            _nome = "Maria";
            _idade = 30;
            _salario = 5000;          
        }

        [Fact]
        public void Deve_Criar_Vendedor()
        {
            var vendedor = new Vendedor(_nome, _idade, _salario);

            Assert.NotNull(vendedor);        
        }

        [Fact]
        public void Deve_Criar_Gerente()
        {
            var gerente = new Gerente(_nome, _idade, _salario);

            Assert.NotNull(gerente);        
        }

        [Fact]
        public void Deve_Criar_Supervisor()
        {
            var supervisor = new Supervisor(_nome, _idade, _salario);

            Assert.NotNull(supervisor);        
        }

        [Fact]
        public void Deve_Add_Bonificacao_Gerente()
        {
            var gerente = new Gerente(_nome, _idade, _salario);
            gerente.Bonificacao(20);
            Assert.NotNull(gerente);        
        }

        [Fact]
        public void Deve_Add_Bonificacao_Supervisor()
        {
            var supervisor = new Supervisor(_nome, _idade, _salario);
            supervisor.Bonificacao(10);
            Assert.NotNull(supervisor);        
        }

        [Fact]
        public void Deve_Add_Bonificacao_Vendedor()
        {
            var vendedor = new Vendedor(_nome, _idade, _salario);
            vendedor.Bonificacao(5);
            Assert.NotNull(vendedor);        
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-50)]
        public void Nao_deve_vendedor_adicionar_bonificacao_se_salario_invalido(double _salarioInvalido)
        {
            var vendedor = new Vendedor(_nome, _idade, _salarioInvalido);
            
            Assert.Throws<ArgumentException>(() => vendedor.Bonificacao(5));
                                               
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-50)]
        public void Nao_deve_Supervisor_adicionar_bonificacao_se_salario_invalido(double _salarioInvalido)
        {
            var supervisor = new Supervisor(_nome, _idade, _salarioInvalido);
            
            Assert.Throws<ArgumentException>(() => supervisor.Bonificacao(5));
                                               
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-50)]
        public void Nao_deve_Gerente_adicionar_bonificacao_se_salario_invalido(double _salarioInvalido)
        {
            var gerente = new Gerente(_nome, _idade, _salarioInvalido);
            
            Assert.Throws<ArgumentException>(() => gerente.Bonificacao(5));
                                               
        }
    }
}
