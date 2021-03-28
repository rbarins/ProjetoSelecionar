
using System;
using CalculosHelper;
using constantes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class CalculosController : ControllerBase
    {
        private readonly ILogger<CalculosController> _logger;

        public CalculosController(ILogger<CalculosController> logger)
        {
            _logger = logger;
        }

        [HttpGet("calculajuros")]
        public ActionResult Calculajuros(double valorinicial, int meses)
        {
            try
            {
                return this.Content(CalculosDeJuros.CalculosDeJurosComposto(valorinicial, meses).ToString());
            }
            catch(Exception e)
            {
                _logger.LogError(e,"Erro na requisição de calculo de juros.");
                return this.BadRequest(new {erro= e.Message});
            }
        }

        [HttpGet("showmethecode")]
        public string Showmethecode()
        {
            return "https://github.com/rbarins/ProjetoSelecionar";
        }
    }
}