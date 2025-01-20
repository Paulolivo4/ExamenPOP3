using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using ExamenPOP3.Models;

namespace ExamenPOP3.Services
{
    public class CocktailServicePO
    {
        private readonly HttpClient _httpClient;
        public CocktailServicePO()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<CocktailPO>> GetCocktails(string query)
        {
            var url = $"https://www.thecocktaildb.com/api/json/v1/1/search.php?s={query}";
            var response = await _httpClient.GetFromJsonAsync<Dictionary<string, List<CocktailPO>>>(url);
            return response?["drinks"] ?? new List<CocktailPO>();
        }

    }
}
