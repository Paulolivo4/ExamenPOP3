using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenPOP3.Models;
using SQLite;


namespace ExamenPOP3.Services
{
    public class CocktailDatabasePO
    {
        private readonly SQLiteAsyncConnection _database;
        public CocktailDatabasePO(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<SavedCocktailPO>().Wait();
        }
        public Task<List<SavedCocktailPO>> GetCocktailsAsync() => _database.Table<SavedCocktailPO>().ToListAsync();
        public Task<int> SaveCocktailAsync(SavedCocktailPO cocktail) => _database.InsertAsync(cocktail);
    }
}
