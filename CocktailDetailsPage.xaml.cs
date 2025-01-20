using ExamenPOP3.ViewModels;

namespace ExamenPOP3;

public partial class CocktailDetailsPage : ContentPage
{
    public CocktailDetailsPage(CocktailDetailsViewModelPO viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}