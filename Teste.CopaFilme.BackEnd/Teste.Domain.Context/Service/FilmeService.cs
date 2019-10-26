
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Teste.CopaFilme.Entity;

namespace Teste.Domain.Context.Service
{
    public class FilmeService
    {
        public async Task<List<Filme>> Consultar()
        {
            var filmes = new List<Filme>();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync("https://copadosfilmes.azurewebsites.net/api/filmes"))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var FilmeJsonString = await response.Content.ReadAsStringAsync();
                        filmes = JsonConvert.DeserializeObject<Filme[]>(FilmeJsonString).ToList();
                    }
                }
            }

            return filmes;
        }
    }
}