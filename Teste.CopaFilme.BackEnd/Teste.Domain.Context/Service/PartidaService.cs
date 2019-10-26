using System.Collections.Generic;
using Teste.CopaFilme.Entity;
using Teste.Domain.Context.Base;
using Teste.Domain.Context.Criterio.Factory;

namespace Teste.Domain.Context.Service
{
    public class PartidaService : TemplateMethod
    {
        private readonly Criterio.Enum.Criterio _criterio;

        public PartidaService(Criterio.Enum.Criterio criterio)
        {
            _criterio = criterio;
        }

        public override Partida ProcessarCopa(List<Filme> filmes)
        {
            return base.ProcessarCopa(filmes);
        }

        protected override List<Partida> GerarPrimeiraRodada(List<Filme> filmes)
        {
            return CriterioFactory.Get(_criterio).GerarPrimeiraRodada(filmes);
        }

        protected override string ValidarGanhador(Partida partida)
        {
            return CriterioFactory.Get(_criterio).VerificarGanhador(partida);
        }

        protected override List<Partida> GerarRodadaEliminatoria(List<Partida> partidas)
        {
            return CriterioFactory.Get(_criterio).GerarRodadaEliminatoria(partidas);
        }
    }
}