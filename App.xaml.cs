using ExamenPOP3.Services;
using System.IO; 
namespace ExamenPOP3;
public partial class App : Application
{
    
    private static CocktailDatabase _database;
    public static CocktailDatabase Database
    {
        get
        {
            if (_database == null)
            {
                // Ruta de la base de datos 
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cocktails.db3");
                _database = new CocktailDatabase(dbPath);
            }
            return _database;
        }
    }
    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}