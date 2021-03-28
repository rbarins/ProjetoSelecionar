using System;

namespace constantes
{
    public class Constantes_CalculoDeJuros
    {
        /// <summary>
        /// Taxa de juros padrão a ser considerada nos calculos de juros do aplicativo.
        /// </summary>
        public const double taxaDeJurosPadrao = .01d;

        public enum JurosCompostosStatusCode : byte
        {
            Valido = 0,
            ValorInicialNegativo=1,
            NumeroDeMesesNegativo=2
        }
    }
}