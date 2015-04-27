using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BackOfficeCommercial
{
    class DAOFamille
    {
        // 3) ouverture de la bdd, envoie de la requeter et récupération de celle-ci avant de la retourner.
        public List<Famille> RecupererFamille()
        {


            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            List<Famille> listeFamilles = new List<Famille>();

            SqlCommand monSQLCommand = new SqlCommand("select * from Famille", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererFamilles = monSQLCommand.ExecuteReader();

            if (readerRecupererFamilles.HasRows)
            {
                while (readerRecupererFamilles.Read())
                {
                    Famille uneFamille = new Famille(readerRecupererFamilles.GetString(0), readerRecupererFamilles.GetString(1));
                    listeFamilles.Add(uneFamille);
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée.");
            }

            readerRecupererFamilles.Close();

            monDAOFactory.CloseConnection();

            return listeFamilles;

        }

        public String RequeteFamille(String unidFamille)
        {

            String requete = "select NomFamille from Famille where iDFamille =" + unidFamille;
            String resultat;

            DAOFactory brd = new DAOFactory();
            SqlCommand maSqlCommand = new SqlCommand(requete, brd.connexionBDD);
           
            resultat = "";
            if (brd.OuvrirConnexion() == true)
            {
                SqlDataReader rs = maSqlCommand.ExecuteReader();

                resultat = maSqlCommand.ToString();
                return resultat;


            }

            return resultat;

        }


    }
}
