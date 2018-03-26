using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoTest
{
    public class Dal : IDal
    {
        public Meteo ObtenirLaMeteoDuJour ()
        {
            // ici , c'est le code pour accéder au service web
            // mais finalement , peu importe ce qu'on y met vu qu'on va bouchonner la méthode
            throw new NotImplementedException ();
        }
    }
}