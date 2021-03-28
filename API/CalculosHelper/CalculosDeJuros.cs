using System;
using constantes;
using static constantes.Constantes_CalculoDeJuros;

namespace CalculosHelper
{
    public static class CalculosDeJuros
    {
        public static void Parametros_JurosCompostos_EstaoValidos(double valorinicial, int meses)
        {
            JurosCompostosStatusCode codigoOperacao =  JurosCompostosStatusCode.Valido;
            if(valorinicial<0) {  codigoOperacao = JurosCompostosStatusCode.ValorInicialNegativo; }
            if(meses<0) {  codigoOperacao = JurosCompostosStatusCode.NumeroDeMesesNegativo; }

            JurosCompostos_ErrorHandler(codigoOperacao);
        }

        public static void JurosCompostos_ErrorHandler(JurosCompostosStatusCode erro)
        {
            if(erro==JurosCompostosStatusCode.Valido){ return; }

            string msgErro = "Erro de requisição: ";

            switch(erro)
            {
                case JurosCompostosStatusCode.ValorInicialNegativo: msgErro+="Valor Inicial negativo."; break;
                case JurosCompostosStatusCode.NumeroDeMesesNegativo: msgErro+="Número de Meses negativo."; break;
                default: msgErro+="Erro desconhecido."; break;
            }

            throw new System.Exception(msgErro);
        }

        public static double CalculosDeJurosComposto(double valorinicial, int meses)
        {
            Parametros_JurosCompostos_EstaoValidos(valorinicial, meses);

            double juros = Constantes_CalculoDeJuros.taxaDeJurosPadrao;
            var valor_Final = valorinicial * Math.Pow(1 + juros, meses);

            return Math.Truncate(valor_Final * 100) / 100;
        }
    }
}