using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sirha.Styles
{
    public class EntryStyles
    {
        private static Style entryStyleAccueil = new Style(typeof(Entry))
        {
            Setters = {
                    new Setter { Property = Entry.TextColorProperty,   Value = CustomColor.TextColorEntryAccueil },
                    new Setter { Property = Entry.PlaceholderColorProperty,   Value = CustomColor.PlaceholderColorEntryAccueil }
                }
        };
        public static Style EntryStyleAccueil { get { return entryStyleAccueil; } }


    }
}
