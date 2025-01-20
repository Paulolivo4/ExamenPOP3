using ExamenPOP3.ViewModels;

namespace ExamenPOP3;

public partial class SavedCocktailsPage : ContentPage
{
    public SavedCocktailsPage()
    {
        InitializeComponent();

        BindingContext = new SavedCocktailsViewModelPO(App.Database);
    }
}