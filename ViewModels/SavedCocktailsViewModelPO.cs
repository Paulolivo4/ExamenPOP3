using CommunityToolkit.Mvvm.ComponentModel;
using ExamenPOP3.Models;
using ExamenPOP3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOP3.ViewModels
{
    public partial class SavedCocktailsViewModelPO : ObservableObject
    {
        private readonly CocktailDatabasePO _database;
        [ObservableProperty]
        private List<SavedCocktailPO> savedCocktails;
       
        public SavedCocktailsViewModelPO(CocktailDatabasePO database)
        {
            _database = database;
            LoadCocktails();
        }
        private async void LoadCocktails()
        {
            SavedCocktails = await _database.GetCocktailsAsync();
        }
    }
}
