namespace ExamenPOP3;
using ExamenPOP3.ViewModels;

public partial class CocktailListPage : ContentPage
{
    private CocktailListViewModelPO _viewModel;
    public CocktailListPage()
    {
        InitializeComponent();
        _viewModel = BindingContext as CocktailListViewModelPO;
    }
    private async void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(e.NewTextValue))
        {
            await _viewModel.LoadCocktailsCommand.ExecuteAsync(e.NewTextValue);
        }
    }
}