using Microsoft.AspNetCore.Mvc;

namespace Baralho.Api.Controllers
{
    [Route("api/v1/baralho/")]
    public class BaralhoController: ControllerBase
    {
        private readonly Modelos.Baralho _baralho;

        public BaralhoController() => _baralho = new Modelos.Baralho();

        [HttpGet]
        [Route("cartas")]
        public IActionResult ObterCartas() => Ok(_baralho.Cartas);

        [HttpGet]
        [Route("cartas-embaralhadas")]
        public IActionResult ObterCartasEmbaralhadas() => Ok(_baralho.CartasEmbaralhadas);

    }
}
