using System.Collections.Generic;

using OnBudget.Helpers;
using OnBudget.Services;
using OnBudget.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OnBudget
{

    public partial class App : Application
    {
        //MUST use HTTPS, neglecting to do so will result in runtime errors on iOS
        public static bool AzureNeedsSetup => AzureMobileAppUrl == "https://CONFIGURE-THIS-URL.azurewebsites.net";
        public static string AzureMobileAppUrl = "https://OnBudget20170924101531.azurewebsites.net";
        public static IDictionary<string, string> LoginParameters => null;

        public App()
        {
            InitializeComponent();

            if (AzureNeedsSetup)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<AzureDataStore>();

            SetMainPage();
        }

        public static void SetMainPage()
        {
            if (!AzureNeedsSetup && !Settings.IsLoggedIn)
            {
                Current.MainPage = new LoginPage();
            }
            else
            {
                GoToMainPage();
            }
        }

        public static void GoToMainPage()
        {
            Current.MainPage = new NavigationPage(new ItemsPage());
        }
    }
}
