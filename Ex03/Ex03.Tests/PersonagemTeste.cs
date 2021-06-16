using System;
using Xunit;
using Ex03.Entities;

namespace Ex03.Tests
{
    public class PersonagemTeste
    {
        private readonly string _nome;
        private readonly int _vida;
        private readonly int _mana;
        private readonly float _xp;
        private readonly int _inteligencia;
        private readonly int _forca;
        private readonly int _level;

        public PersonagemTeste()
        {
            _nome = "Dumbleodore";
            _vida = 5;
            _mana = 10;
            _xp = 10f;
            _inteligencia = 20;
            _forca = 50;
            _level = 10;
        }
        [Fact]
        public void Deve_criar_guerreiro()
        {
            var guerreiro = new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level);

            Assert.NotNull(guerreiro);
        }

        [Fact]
        public void Deve_criar_um_mago()
        {
            var mago = new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level);

            Assert.NotNull(mago);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_pode_mago_aprender_magia_invalida(string magiaInvalida)
        {
            Assert.Throws<ArgumentException>(() => new Mago(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level).aprenderMagia(magiaInvalida));
                                    
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Nao_pode_guerreiro_aprender_habilidade_invalida(string habilidadeInvalida)
        {
            Assert.Throws<ArgumentException>(() => new Guerreiro(_nome, _vida, _mana, _xp, _inteligencia, _forca, _level).aprenderHabilidade(habilidadeInvalida));
                                    
        }
    }
}
