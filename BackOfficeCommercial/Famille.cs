using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeCommercial
{
    class Famille
    {
        String unNom;
        String unId;

        public Famille(String Id, String Nom)
        {
            unNom = Nom;
            unId = Id;
        }
        public Famille()
        {
        }

        public String UnId
        {
            get { return unId; }
            set { unId = value; }
        }

        public String UnNom
        {
            get { return unNom; }
            set { unNom = value; }
        }



    
        // 2 ) méthode qui renvoie une liste famille
        public List<Famille> RecupererlesFamille()
        {
            List<Famille> ListeFamille = new List<Famille>();

            DAOFamille lesFamilles = new DAOFamille();
            ListeFamille = lesFamilles.RecupererFamille();

            return ListeFamille;
        }

    }
}
