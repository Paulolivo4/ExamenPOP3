using ExamenPOP3.ViewModels;

namespace ExamenPOP3;

public partial class CocktailDetailsPage : ContentPage
{
    public CocktailDetailsPage(CocktailDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}