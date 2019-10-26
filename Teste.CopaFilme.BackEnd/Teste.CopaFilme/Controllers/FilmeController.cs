using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Teste.CopaFilme.Entity;
using Teste.Domain.Context.Service;

namespace Teste.CopaFilme.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Filme>>> Consultar()
        {
            List<Filme> filmes;

            try
            {
                filmes = await new FilmeService().Consultar();

                if (filmes.Count == 0)               
                    return NotFound();               
                else               
                    return Ok(filmes);            
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}