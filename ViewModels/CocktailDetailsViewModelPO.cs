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
    public partial class CocktailDetailsViewModelPO : ObservableObject
    {
        public CocktailDetailsViewModelPO()
        {

        }

        private readonly CocktailDatabasePO _database;
        [ObservableProperty]
        private CocktailPO selectedCocktail;
        public IRelayCommand SaveCommand { get; }
        public CocktailDetailsViewModelPO(CocktailDatabasePO database)
        {
            _database = database;
            SaveCommand = new RelayCommand(SaveCocktail);
        }
        private async void SaveCocktail()
        {
            var savedCocktail = new SavedCocktailPO
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
