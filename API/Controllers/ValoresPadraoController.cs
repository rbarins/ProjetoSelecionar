using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using constantes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValoresPadraoController : ControllerBase
    {
        private readonly ILogger<ValoresPadraoController> _logger;

        public ValoresPadraoController(ILogger<ValoresPadraoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("taxaJuros")]
        public double TaxaJuros()
        {
            return Constantes_CalculoDeJuros.taxaDeJurosPadrao;
        }
    }
}