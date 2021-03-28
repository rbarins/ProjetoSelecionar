using CalculosHelper;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        /// <summary>
        /// Para rodar, leve o cmd até a pasta "Tests" e de um comando "dotnet test"
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void MeuTeste()
        {
            var resultadoMeuTeste = CalculosDeJuros.CalculosDeJurosComposto(1000,2);
            Assert.IsFalse(resultadoMeuTeste!= 1020.1d);
        }

        [Test]
        public void TesteDoEnunciado()
        {
            var resultadoTesteDoEnunciado = CalculosDeJuros.CalculosDeJurosComposto(100, 5);
            Assert.IsFalse(resultadoTesteDoEnunciado != 105.1d);
        }
    }
}