using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Teste.CopaFilme.Entity;
using Teste.Domain.Context.Criterio.Enum;
using Teste.Domain.Context.Service;

namespace Teste.CopaFilme.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidaController : ControllerBase
    {
        private const Criterio criterio = Criterio.Lambda;

        [HttpPost]
        public ActionResult<Partida> ProcessarCopa([FromBody] List<Filme> filmes)
        {
            Partida result;

            try
            {
                result = new PartidaService(criterio).ProcessarCopa(filmes);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
