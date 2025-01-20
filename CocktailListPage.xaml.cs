namespace ExamenPOP3;
using ExamenPOP3.ViewModels;

public partial class CocktailListPage : ContentPage
{
    private CocktailListViewModel _viewModel;
    public CocktailListPage()
    {
        InitializeComponent();
        _viewModel = BindingContext as CocktailListViewModel;
    }
    private async void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue))
        {
            await _viewModel.LoadCocktailsCommand.ExecuteAsync(e.NewTextValue);
        }
    }
}