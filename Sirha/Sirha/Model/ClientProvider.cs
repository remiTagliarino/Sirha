using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirha.Model
{
    public class ClientProvider
    {
        private static readonly List<Client> Clients = new List<Client>
                                              {
                                                  new Client() {Nom= "Louis Vitton", Ville="Lyon", Adresse="99 rue de gerland" },
                                                  new Client() {Nom= "Guess", Ville="Lyon", Adresse="99 rue de gerland" },
                                                  new Client() {Nom= "Gucci", Ville="Lyon", Adresse="99 rue de gerland" },
                                                  new Client() {Nom= "Lacoste", Ville="Lyon" , Adresse="99 rue de gerland"},
                                                  new Client() {Nom= "Nike", Ville="Lyon", Adresse="99 rue de gerland" },
                                                  new Client() {Nom= "Puma", Ville="Lyon" , Adresse="99 rue de gerland"},
                                              };

        public static List<Client> GetAllClient()
        {
            return Clients;
        }
    }
}
