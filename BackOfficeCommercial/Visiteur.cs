using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeCommercial
{
    class Visiteur
    {
        private int id;
        private String nom;
        private String prenom;

        public Visiteur(int unId, String unNom, String unPrenom)
        {
            id = unId;
            nom = unNom;
            prenom = unPrenom;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }
}