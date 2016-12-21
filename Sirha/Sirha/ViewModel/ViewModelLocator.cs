using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using Sirha.View;
using Sirha.Services;
namespace Sirha.ViewModel
{
    public class ViewModelLocator
    {
        static ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            var dialog = new DialogService();
            SimpleIoc.Default.Register<IDialogService>(() => dialog);

            var navigation = new NavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigation);
            SimpleIoc.Default.Register<INavigationService2>(() => navigation);

            initializeNavigation(navigation);
        }
        private static void initializeNavigation(NavigationService navigationService)
        {
            // key => View pour la navigation
            navigationService.Configure(PageName.Accueil.ToString(), typeof(Accueil));
            // enregistrement des types de ViewModels pour le locator
            SimpleIoc.Default.Register<AccueilViewModel>();
        }
        public object Accueil => ServiceLocator.Current.GetInstance<AccueilViewModel>();
        // navigation service
        // original interface from Mvvm Light
        public INavigationService NavigationService => ServiceLocator.Current.GetInstance<INavigationService>();
        // enhanced version by OD with modal support
        public INavigationService2 NavigationService2 => ServiceLocator.Current.GetInstance<INavigationService2>();
        // dialog service
        public IDialogService DialogService => ServiceLocator.Current.GetInstance<IDialogService>();
    }
}
