using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    class DAOFactory
    {
        /* Déclaration des attributs publics */

        public SqlConnection connexionBDD;
        public string serveur;
        public string bdd;
        public string user;
        public string mdp;
        public string attenteConnexion;

        public DAOFactory()
        {
            Initialize(); // Appel de la méthode Initialize()
        }

        public void Initialize()
        {
            serveur = "172.17.21.10"; // On indique ici l'adresse ip du serveur distant
            bdd = "TeamA2"; // On indique la base de données sur laquelle on travaille
            user = "piat"; // On indique le nom d'utilisateur pour se connecter à la bdd
            mdp = "btssio-2015"; // On indique le mot de passe pour se connecter à la bdd
            attenteConnexion = "60"; // On indique le délai d'attente maximum pour se connecter

            string connexionString = "SERVER=" + serveur + ";" + "DATABASE=" + // On concatène le tout dans un string connexionString
            bdd + ";" + "UID=" + user + ";" + "PASSWORD=" + mdp + ";";

            connexionBDD = new SqlConnection(connexionString); // On crée la connexion avec notre string connexionString

            /* TEST BDD
             * bdd = "BackOfficeteam4";
             * user = "lagasse";
             * mdp = "robin-2015"; */
        }

        public bool OuvrirConnexion()
        {
            try
            {
                connexionBDD.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           
        }

        public bool CloseConnection()
        {
            try
            {
                connexionBDD.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
