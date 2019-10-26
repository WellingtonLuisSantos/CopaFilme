using System.Collections.Generic;
using System.Linq;

namespace Teste.CopaFilme.Entity
{
    public class Partida
    {
        public Filme Filme1 { get; set; }

        public Filme Filme2 { get; set; }

        public string Vencedor { get; set; }

        public Filme ObterVencedor()
        {
            if (Filme1.Id == Vencedor)
            {
                return Filme1;
            }
            else
            {
                return Filme2;
            }
        }

        public Filme ObterPrimeiroOrdernadoPorTitulo()
        {
           return (new List<Filme>() { this.Filme1, this.Filme2 }).OrderBy(x => x.Titulo).FirstOrDefault();
        }
    }
}
