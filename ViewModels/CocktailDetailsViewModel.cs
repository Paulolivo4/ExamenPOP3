using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenPOP3.Models;
using ExamenPOP3.Services;

namespace ExamenPOP3.ViewModels
{
    public partial class CocktailDetailsViewModel : ObservableObject
    {
        private readonly CocktailDatabase _database;
        [ObservableProperty]
        private Cocktail selectedCocktail;
        public IRelayCommand SaveCommand { get; }
        public CocktailDetailsViewModel(CocktailDatabase database)
        {
            _database = database;
            SaveCommand = new RelayCommand(SaveCocktail);
        }
        private async void SaveCocktail()
        {
            var savedCocktail = new SavedCocktail
            {
                Name = SelectedCocktail.StrDrink,
                Category = SelectedCocktail.StrCategory,
                Instructions = SelectedCocktail.StrInstructions,
                ImageUrl = SelectedCocktail.StrDrinkThumb
            };
            await _database.SaveCocktailAsync(savedCocktail);
        }
    }
}
