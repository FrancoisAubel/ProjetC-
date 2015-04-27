using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    class DAOClient
    {
        public List<Client> recupererLesClients()
        {
            List<Client> tousLesClients = new List<Client>(); // Création d'une List permettant de stocker tous les clients

            DAOFactory monDaoFactory1 = new DAOFactory(); // Création d'un objet DAOFactory
            monDaoFactory1.OuvrirConnexion(); // On ouvre la connexion sur l'objet monDaoFactory1
            SqlCommand maSqlCommand = new SqlCommand("SELECT * FROM dbo.personneClient;", monDaoFactory1.connexionBDD); // On crée une requete
            SqlDataReader recupClientsDR = maSqlCommand.ExecuteReader(); // On exécute la requete
            if (recupClientsDR.HasRows) // Si on trouve des valeurs
            {
                while (recupClientsDR.Read()) // On parcourt les résultats
                {
                    Client unClient = new Client(recupClientsDR.GetInt32(0), // On crée un objet client et on récupère les valeurs correspondantes
                    recupClientsDR.GetString(1).Trim(),
                    recupClientsDR.GetString(2).Trim(),
                    recupClientsDR.GetString(3).Trim(), // Trim permet de supprimer les espaces vides
                    recupClientsDR.GetString(4).Trim(),
                    recupClientsDR.GetString(5).Trim(),
                    recupClientsDR.GetString(6).Trim(),
                    recupClientsDR.GetString(7).Trim(),
                    recupClientsDR.GetInt32(8),
                    recupClientsDR.GetString(9).Trim());
                    tousLesClients.Add(unClient);
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée"); // Message d'erreur dans le cas où il n'y a pas de valeurs
            }
            return tousLesClients; // On retourne la liste des clients
        } // Fonction permettant de récupérer les clients stockées en bdd

        public String trouverNomProfessionParId(int unId)
        {
            String resultat = ""; // On initialise notre résultat à null au départ
            DAOFactory monDaoFactory1 = new DAOFactory(); // Création d'un objet DAOFactory
            monDaoFactory1.OuvrirConnexion(); // Connexion à la BDD
            SqlCommand maSqlCommand = new SqlCommand("SELECT nom FROM dbo.typeProfessionnel WHERE idTypeProf =" + unId + ";", monDaoFactory1.connexionBDD); // Création de la requete
            SqlDataReader recupClientsDR = maSqlCommand.ExecuteReader(); // On exécute la requete
            if (recupClientsDR.HasRows) // S'il y a des résultats
            {
                while (recupClientsDR.Read()) // On parcourt nos rrésultats
                {
                    resultat = recupClientsDR.GetString(0); // On récupère la valeur associée et on la stocke dans résultat
                }
            }
            else
            {
                resultat = "Aucun résultat"; // S'il n'y a aucun résultat, on affecte resultat à "Aucun résultat
            }
            return resultat; // On retourne le resultat
        } // Fonction permettant de retourner le type de profession selon un ID passé en paramètre

        public List<String> chargerLesTypesProfession(String unNom)
        {
            List<String> toutesLesProfessions = new List<String>();
            return toutesLesProfessions;
        } // Fonction permettant de charger les différentes professions

        public static void ajouterClient(int unIdClient, String unNom, String unPrenom, String uneRaison, String uneVille, String uneAdresse, String unCp, String unMail, Int32 unType, String unTelephone)
        {
            try
            {
                String requete = "INSERT INTO dbo.personneClient(idClient, nom, prenom, raisonSocial, ville, adresse, cp, email, idTypeProfessionel, telephone) VALUES("
                + unIdClient + ","
                + "\'" + unNom + "\'" + ","
                + "\'" + unPrenom + "\'" + ","
                + "\'" + uneRaison + "\'" + ","
                + "\'" + uneVille + "\'" + ","
                + "\'" + uneAdresse + "\'" + ","
                + "\'" + unCp + "\'" + ","
                + "\'" + unMail + "\'" + ","
                + unType + ","
                + "\'" + unTelephone + "\'" + ");";

                DAOFactory monDaoFactory1 = new DAOFactory(); // Création de l'objet DAOFactory
                monDaoFactory1.OuvrirConnexion(); // On se connecte à la BDD
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory1.connexionBDD); // On associe notre requete
                maSqlCommand.ExecuteReader(); // On exécute la requete

                MessageBox.Show("Ajout effectué avec succès dans la base de données !"); // On affiche un message en cas de succès
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Hey ! Un problème est survenu : " + exe.ToString()); // On affiche un message en cas d'échec
            }
        }

        public static void modifierClient(int unIdClient, String unNom, String unPrenom, String uneRaison, String uneVille, String uneAdresse, String unCp, String unMail, Int32 unType, String unTelephone)
        {
            try
            {
                String requete = "UPDATE dbo.personneClient SET dbo.personneClient.nom = " + "\'" + unNom + "\'" +
                     ", dbo.personneClient.prenom = " + "\'" + unPrenom + "\'" +
                     ", dbo.personneClient.raisonSocial = " + "\'" + uneRaison + "\'" +
                     ", dbo.personneClient.ville = " + "\'" + uneVille + "\'" +
                     ", dbo.personneClient.adresse = " + "\'" + uneAdresse + "\'" +
                     ", dbo.personneClient.cp = " + "\'" + unCp + "\'" +
                     ", dbo.personneClient.email = " + "\'" + unMail + "\'" +
                     ", dbo.personneClient.idTypeProfessionel = " + "\'" + unType + "\'" +
                     ", dbo.personneClient.telephone = " + "\'" + unTelephone + "\'" +
                     " WHERE dbo.personneClient.idClient = " + "\'" + unIdClient + "\'" + ";";

                DAOFactory monDaoFactory1 = new DAOFactory(); // Création de l'objet DAOFactory
                monDaoFactory1.OuvrirConnexion();  // On se connecte à la BDD
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory1.connexionBDD); // On associe notre requete
                maSqlCommand.ExecuteReader(); // On exécute la requete

                MessageBox.Show("Client modifié avec succès dans la base de données !"); // On affiche un message en cas de succès
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Hey ! Un problème est survenu : " + exe.ToString()); // On affiche un message en cas d'échec
            }
        }

        public static void supprimerClient(int unId, String unNom, String unPrenom)
        {
            try
            {
                unNom = "\'" + unNom + "\'";
                unPrenom = "\'" + unPrenom + "\'";

                String requete = "DELETE FROM dbo.personneClient WHERE idClient = " + unId + " AND nom = " + unNom + " AND prenom = " + unPrenom + ";";

                DAOFactory monDaoFactory1 = new DAOFactory(); // Création de l'objet DAOFactory
                monDaoFactory1.OuvrirConnexion(); // On se connecte à la BDD
                SqlCommand maSqlCommand = new SqlCommand(requete, monDaoFactory1.connexionBDD); // On associe notre requete
                maSqlCommand.ExecuteReader(); // On l'exécute

                MessageBox.Show("Suppression effectué avec succès dans la base de données !"); // Message en cas de succès
            }
            catch (SqlException exe)
            {
                MessageBox.Show("Erreur rencontrée : " + exe.ToString()); // Message en cas d'échec
            }
        }

        /*public int trouverIdProfessionnelParNomProfession(String unNom)
        {
        int resultat = -1;
        daoFactory monDaoFactory2 = new daoFactory();
        monDaoFactory2.OuvrirConnexion();
        SqlCommand maSqlCommand2 = new SqlCommand("SELECT idTypeProf FROM dbo.typeProfessionnel WHERE nom ="+unNom+";", monDaoFactory2.connexionBDD);
        SqlDataReader recupClientsDR2 = maSqlCommand2.ExecuteReader();
        if (recupClientsDR2.HasRows)
        {
        while (recupClientsDR2.Read())
        {
        resultat = recupClientsDR2.GetInt32(0);
        }
        }
        else
        {
        resultat = -1;
        }
        return resultat;
        }
        * */
    }
}