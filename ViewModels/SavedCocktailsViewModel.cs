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
    public partial class SavedCocktailsViewModel : ObservableObject
    {
        private readonly CocktailDatabase _database;
        [ObservableProperty]
        private List<SavedCocktail> savedCocktails;
       
        public SavedCocktailsViewModel(CocktailDatabase database)
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
