using Ex02.Entities;
using Xunit;
using System.Collections.Generic;
using System;

namespace Ex02.Tests.Entities
{
    public class Testes
    {
        private readonly string _nomeLivro;
        private readonly double _precoLivro;
        private readonly int _quantidadeLivro;
        private readonly string _autor;
        private readonly string _tema;
        private readonly int _quantidadePaga;
        private readonly string _nomeVideoGame;
        private readonly double _precoVideoGame;
        private readonly int _quantidadeVideoGame;
        private readonly string _marca;
        private readonly string _modelo;
        private readonly bool _isUsado;
        private readonly string _nomeLoja;
        private readonly string _cnpj;


        public Testes()
        {
            _nomeLivro = "Admirável Mundo Novo";
            _precoLivro = 90.0;
            _quantidadeLivro = 10;
            _autor = "aldous Huxley";
            _tema = "Clássicos";
            _quantidadePaga = 100;
            _nomeVideoGame = "Nintendo";
            _precoVideoGame = 2000.0;
            _quantidadeVideoGame = 20;
            _marca = "Nintendo";
            _modelo = "Switch";
            _isUsado = false;
            _nomeLoja = "Olist SP";
            _cnpj = "56.504.108/0001-76";
        }

        [Fact]
        public void Deve_criar_livro()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);

            Assert.NotNull(livro);
        }

        [Fact]
        public void Deve_criar_video_game()
        {
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            Assert.NotNull(videoGame);
        }

        [Fact]
        public void Deve_criar_loja()
        {
            var livro = new Livro(_nomeLivro, _precoLivro, _quantidadeLivro, _autor, _tema, _quantidadePaga);
            var videoGame = new VideoGame(_nomeVideoGame, _precoVideoGame, _quantidadeVideoGame, _marca, _modelo, _isUsado);

            List<Livro> listLivro = new List<Livro>();
            listLivro.Add(livro);

            List<VideoGame> listVideoGame = new List<VideoGame>();
            listVideoGame.Add(videoGame);

            var loja = new Loja(_nomeLoja, _cnpj, listLivro, listVideoGame);

            Assert.NotNull(loja);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-10)]
        [InlineData(-500)]
        public void Nao_deve_calcular_imposto_de_livro_se_preco_invalido(double precoInvalido)
        {
            Assert.Throws<ArgumentException>(() => new Livro(_nomeLivro, precoInvalido, _quantidadeLivro, _autor, _tema, _quantidadePaga).calculaImposto());

        }
    }
}