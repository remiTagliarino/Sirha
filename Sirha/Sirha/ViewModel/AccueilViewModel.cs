using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using System.Collections.ObjectModel;
using Sirha.Model;
using System.Collections.Generic;

namespace Sirha.ViewModel
{
    public class AccueilViewModel : ViewModelBase
    {
        private string nom = "", commercial = "", adresse = "", codePostal = "", ville = "", region = "";
        public List<Client> listeClients => ClientProvider.GetAllClient();
        private RelayCommand searchCommand;
        public ICommand Search => searchCommand ??
                                         (searchCommand = new RelayCommand(SearchExecute, CanSearch));
        public string Nom
        {
            get { return nom; }
            set
            {
                if (Set(ref nom, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string Commercial
        {
            get { return commercial; }
            set
            {
                if (Set(ref commercial, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string Adresse
        {
            get { return adresse; }
            set
            {
                if (Set(ref adresse, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                if (Set(ref codePostal, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string Ville
        {
            get { return ville; }
            set
            {
                if (Set(ref ville, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }
        public string Region
        {
            get { return region; }
            set
            {
                if (Set(ref region, value))
                {
                    searchCommand.RaiseCanExecuteChanged();
                }
            }
        }

        private void SearchExecute()
        {
            var dialog = ServiceLocator.Current.GetInstance<IDialogService>();
            dialog.ShowMessage("Etes-vous sûr ?", "RAZ des champs", "Oui", "Annuler",
                r =>
                {

                });
        }

        public bool CanSearch()
        {
            return OneEntryNotEmpty() && IsCodePostal();
        }

        private bool OneEntryNotEmpty()
        {
            if (Nom.Length > 0 || Commercial.Length > 0 ||
                CodePostal.Length > 0 || Ville.Length > 0 ||
                Region.Length > 0 || Adresse.Length > 0)
            {
                return true;
            }
            return false;
        }
        
        private bool IsCodePostal()
        {
            if(codePostal.Length > 0)
            {
                int result;
                return int.TryParse(codePostal, out result);
            }
            return true; 
        }

     
    }
}
