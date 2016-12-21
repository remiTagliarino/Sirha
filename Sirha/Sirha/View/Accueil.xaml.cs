using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Sirha.View
{
    public partial class Accueil : ContentPage
    {
        public Accueil()
        {
            BindingContext = App.Locator.Accueil;
            InitializeComponent();
        }
    }
}
