using System.Threading.Tasks;
using GalaSoft.MvvmLight.Views;
using Xamarin.Forms;


namespace Sirha.Services
{
    public interface INavigationService2 : INavigationService
    {
        Task ModalNavigateTo(string pageKey);
        Task ModalNavigateTo(string pageKey, object parameter, bool animate = true);
        Task ModalDismiss();
        void NavigateTo(string pageKey, object parameter, bool animate);
        void Initialize(Page navigationPage);
    }
}
