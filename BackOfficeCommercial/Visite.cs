using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeCommercial
{
    class Visite
    {
        Client client;
        DateTime date;
        String heure;
        String compteRendu;

        public Visite(Client unClient, DateTime uneDate, String uneHeure, String unCompteRendu)
        {
            client = unClient;
            date = uneDate;
            heure = uneHeure;
            compteRendu = unCompteRendu;
        }

        internal Client Client
        {
            get { return client; }
            set { client = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public String Heure
        {
            get { return heure; }
            set { heure = value; }
        }

        public String CompteRendu
        {
            get { return compteRendu; }
            set { compteRendu = value; }
        }
    }
}