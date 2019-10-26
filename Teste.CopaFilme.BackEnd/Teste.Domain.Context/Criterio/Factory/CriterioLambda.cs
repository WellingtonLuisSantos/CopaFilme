using System;
using System.Collections.Generic;
using System.Linq;
using Teste.CopaFilme.Entity;
using Teste.Domain.Context.Criterio.Interface;

namespace Teste.Domain.Context.Criterio.Factory
{
    public class CriterioLambda : ICriterio
    {
        public string VerificarGanhador(Partida partida)
        {
            if (partida.Filme1.Nota > partida.Filme2.Nota)
            {
                return partida.Filme1.Id;
            }
            else if (partida.Filme2.Nota > partida.Filme1.Nota)
            {
                return partida.Filme2.Id;
            }
            else
            {
                return partida.ObterPrimeiroOrdernadoPorTitulo().Id;
            }
        }

        public List<Partida> GerarPrimeiraRodada(List<Filme> filmes)
        {
            var novasPartidas = new List<Partida>();

            filmes = filmes.OrderBy(x => x.Titulo).ToList();

            if (filmes.Count % 2 != 0)
            {
                throw new FormatException("Não é possivel gerar a rodada devido o numero de filme ser impar!");
            }

            for (int i = 0; i <= filmes.Count; i++)
            {
                if (filmes.Count / 2 == i)
                    break;

                novasPartidas.Add(new Partida()
                {
                    Filme1 = filmes[i],
                    Filme2 = filmes[filmes.Count - (i + 1)]
                });
            }

            return novasPartidas;
        }

        public List<Partida> GerarRodadaEliminatoria(List<Partida> partidas)
        {
            var novasPartidas = new List<Partida>();

            if (partidas.Count % 2 != 0)
            {
                throw new FormatException("Não é possivel gerar a proxima rodada devido o numero de filme ser impar!");
            }

            for (int i = 0; i <= partidas.Count; i++)
            {
                if (partidas.Count / 2 == i)
                    break;

                novasPartidas.Add(new Partida()
                {
                    Filme1 = partidas[i].ObterVencedor(),
                    Filme2 = partidas[partidas.Count - (i + 1)].ObterVencedor()
                });
            }

            return novasPartidas;
        }
    }
}