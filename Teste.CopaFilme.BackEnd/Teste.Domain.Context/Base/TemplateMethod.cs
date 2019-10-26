using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.CopaFilme.Entity;

namespace Teste.Domain.Context.Base
{
    public abstract class TemplateMethod
    {
        public virtual Partida ProcessarCopa(List<Filme> filmes)
        {
            bool hasCampeao = false;
            List<Partida> rodada = GerarPrimeiraRodada(filmes);

            while (!hasCampeao)
            {
                Parallel.ForEach(rodada, partida =>
                {
                    partida.Vencedor = ValidarGanhador(partida);
                });

                if (EhPartidaFinal(rodada))
                {
                    hasCampeao = true;
                }
                else
                {
                    rodada = GerarRodadaEliminatoria(rodada);
                }
            }

            return rodada.FirstOrDefault();
        }
        
        protected abstract List<Partida> GerarPrimeiraRodada(List<Filme> filmes);

        protected abstract string ValidarGanhador(Partida partida);

        protected abstract List<Partida> GerarRodadaEliminatoria(List<Partida> partida);

        private bool EhPartidaFinal(List<Partida> partidas)
        {
            if (partidas.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}