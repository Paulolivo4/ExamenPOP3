using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPOP3.Models;
using SQLite;

namespace ExamenPOP3.Services
{
    public class CocktailDatabase
    {
        private readonly SQLiteAsyncConnection _database;
        public CocktailDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SavedCocktail>().Wait();
        }
        public Task<List<SavedCocktail>> GetCocktailsAsync() => _database.Table<SavedCocktail>().ToListAsync();
        public Task<int> SaveCocktailAsync(SavedCocktail cocktail) => _database.InsertAsync(cocktail);
    }
}
