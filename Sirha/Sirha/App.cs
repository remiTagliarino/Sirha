using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Sirha.Services;
using Sirha.ViewModel;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Sirha.View;
using Sirha.Styles;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Sirha
{
    public class App : Application
    {
        public App()
        {
           
            Resources = new ResourceDictionary();
            Resources.Add("EntryStyleAccueil", EntryStyles.EntryStyleAccueil);

            MobileCenter.Start(typeof(Analytics), typeof(Crashes));
            MobileCenter.Configure("09d25512-9711-4233-bebe-bc6e31a391c9");
            Locator = new ViewModelLocator();
            MainPage = new NavigationPage(new Accueil());
        }
    
        public static ViewModelLocator Locator { get; private set; }
        protected override void OnPropertyChanged(string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);
            if (propertyName != nameof(MainPage)) return;
            var dialog = ServiceLocator.Current.GetInstance<IDialogService>() as DialogService;
            dialog?.Initialize(MainPage);
            var nav = ServiceLocator.Current.GetInstance<INavigationService2>();
            nav?.Initialize(MainPage);
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
