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
    public partial class CocktailListViewModelPO : ObservableObject
    {
        private readonly CocktailServicePO _service;
        [ObservableProperty]
        private List<CocktailPO> cocktails;
        public CocktailListViewModelPO()
        {
            _service = new CocktailServicePO();
            LoadCocktailsCommand = new AsyncRelayCommand<string>(LoadCocktails);
        }
        public IAsyncRelayCommand<string> LoadCocktailsCommand { get; }
        private async Task LoadCocktails(string query)
        {
            Cocktails = await _service.GetCocktails(query);
        }
    }
}
