using System.Collections.Generic;
using Teste.CopaFilme.Entity;

namespace Teste.Domain.Context.Criterio.Interface
{
    public interface ICriterio
    {
        string VerificarGanhador(Partida partida);

        List<Partida> GerarPrimeiraRodada(List<Filme> filmes);

        List<Partida> GerarRodadaEliminatoria(List<Partida> partidas);
    }
}