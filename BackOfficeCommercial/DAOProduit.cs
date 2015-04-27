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
using System.Collections;


namespace BackOfficeCommercial
{
    class DAOProduit
    {





        public List<Produit> RecupererNomCommercial()
        {


            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            List<Produit> listeNoms = new List<Produit>();

            SqlCommand monSQLCommand = new SqlCommand("select * from Produit", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererNoms = monSQLCommand.ExecuteReader();

            if (readerRecupererNoms.HasRows)
            {
                while (readerRecupererNoms.Read())
                {
                    try
                    {
       
                        Produit unProduit = new Produit(readerRecupererNoms.GetString(0), readerRecupererNoms.GetString(1), readerRecupererNoms.GetString(2), readerRecupererNoms.GetString(3), readerRecupererNoms.GetString(4), readerRecupererNoms.GetString(5), readerRecupererNoms.GetString(6), readerRecupererNoms.GetDouble(7), readerRecupererNoms.GetDouble(8),readerRecupererNoms.GetString(9));
                        listeNoms.Add(unProduit);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Aucune valeur trouvée.");
            }

            readerRecupererNoms.Close();

            monDAOFactory.CloseConnection();

            return listeNoms;

        }
         

        
        public void SupprimerProduit(String unNom)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();
 

            try
            {

                SqlCommand monSQLCommand = new SqlCommand("delete from Produit where NomCommercial = '" + unNom+"'", monDAOFactory.connexionBDD);

                SqlDataReader ExecuterSupression = monSQLCommand.ExecuteReader();
                MessageBox.Show("Produit Supprimé");
                ExecuterSupression.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            

            monDAOFactory.CloseConnection();


            

            
        }
        public String RecupererValeur(String unDetail, String unNom)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            String uneValeur = "";

            SqlCommand monSQLCommand = new SqlCommand("select " + unDetail + " from Produit Where NomCommercial = '" + unNom+"'", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {
                 
                    while (readerRecupererValeur.Read())
                    {
                        uneValeur = readerRecupererValeur.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            readerRecupererValeur.Close();

            monDAOFactory.CloseConnection();

            return uneValeur;
        }
        public double RecupererValeurDouble(String unDetail, String unNom)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            double uneValeur = 0;
        
            SqlCommand monSQLCommand = new SqlCommand("select " + unDetail + " from Produit Where NomCommercial = '" + unNom + "'", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {

                    while (readerRecupererValeur.Read())
                    {
                        uneValeur = readerRecupererValeur.GetDouble(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            readerRecupererValeur.Close();

            monDAOFactory.CloseConnection();
        
            return uneValeur;
        }

        public bool VerificationNomCommercial(String unNom)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            bool UnNomexiste = false;
            SqlCommand monSQLCommand = new SqlCommand("select NomCommercial from Produit Where NomCommercial = '" + unNom + "'", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {

                    while (readerRecupererValeur.Read())
                    {
                        String UnNom = readerRecupererValeur.GetString(0);
                        if (unNom != "")
                        {
                            UnNomexiste = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            readerRecupererValeur.Close();

            monDAOFactory.CloseConnection();

            return UnNomexiste;
        }

        public bool VerificationNumero(String unNumero)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            bool UnNumeroExiste = false;
            SqlCommand monSQLCommand = new SqlCommand("select Numero from Produit Where Numero = '" + unNumero + "'", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {

                    while (readerRecupererValeur.Read())
                    {
                        String UnNom = readerRecupererValeur.GetString(0);
                        if (unNumero != "")
                        {
                            UnNumeroExiste = true;
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            readerRecupererValeur.Close();

            monDAOFactory.CloseConnection();

            return UnNumeroExiste;
        }
        public String RecupererValeurFamille(String unDetail, String unNom)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();

            String uneValeur = "";

            SqlCommand monSQLCommand = new SqlCommand("select " + unDetail + " from Produit Where NomCommercial = '" + unNom + "'", monDAOFactory.connexionBDD);

            SqlDataReader readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {

                    while (readerRecupererValeur.Read())
                    {
                        uneValeur = readerRecupererValeur.GetString(0);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            monSQLCommand = new SqlCommand("select NomFamille from Famille Where IdFamille = " + uneValeur, monDAOFactory.connexionBDD);
            readerRecupererValeur.Close();
            readerRecupererValeur = monSQLCommand.ExecuteReader();
            try
            {
                if (readerRecupererValeur.HasRows)
                {

                    while (readerRecupererValeur.Read())
                    {
                        uneValeur = readerRecupererValeur.GetString(0);
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            readerRecupererValeur.Close();

            monDAOFactory.CloseConnection();

            return uneValeur;
        }

        public void EditProduit(String Numero, String Dosage,String Famille,String NomCommercial,double Prix,String ContreIndication,String Effet, String Interaction, double PrixEchantillon, String Presentation)
        {
            DAOFactory monDAOFactory = new DAOFactory();
            
            monDAOFactory.OuvrirConnexion();


            try
            {
               
                String unPrix = Prix.ToString().Replace(',', '.');
                String unPrixEchantillon = PrixEchantillon.ToString();
                unPrixEchantillon = unPrixEchantillon.Replace(',', '.');
                SqlCommand monSQLCommand = new SqlCommand("UPDATE Produit SET PrixVente = " + unPrix + " , Dosage = '" + Dosage + "', EffetTherapeutique = '" + Effet + "', ContreIndication = '" + ContreIndication + "', Interactions = '" + Interaction + "', PrixEchantillon = " + unPrixEchantillon + ", Presentation = '" + Presentation + "' WHERE Numero =" + Numero, monDAOFactory.connexionBDD);
                
                SqlDataReader ExecuterEdition = monSQLCommand.ExecuteReader();
                ExecuterEdition.Close();
                SqlCommand monSQLCommandFamille = new SqlCommand("Update Produit SET IdFamille = (Select IdFamille From Famille WHERE NomFamille = '"+Famille+"') Where Numero ="+Numero , monDAOFactory.connexionBDD);

                SqlDataReader readerRecupererValeur = monSQLCommandFamille.ExecuteReader();
                MessageBox.Show("Produit Edité");
                ExecuterEdition.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            monDAOFactory.CloseConnection();





        }
        public void NouveauProduit(String Numero, String Dosage, String Famille, String NomCommercial, double Prix, String ContreIndication, String Effet, String Interaction, double PrixEchantillon,String Presentation)
        {
            DAOFactory monDAOFactory = new DAOFactory();

            monDAOFactory.OuvrirConnexion();


            try
            {
                String unPrix = Prix.ToString().Replace(',', '.');
                String unPrixEchantillon = PrixEchantillon.ToString().Replace(',', '.');

                SqlCommand monSQLCommand = new SqlCommand("INSERT INTO Produit VALUES ('" + Numero + "' ,'" + Dosage + "','" + NomCommercial + "' , '" + Effet + "','" + ContreIndication + "', (Select IdFamille From Famille WHERE NomFamille = '" + Famille + "') ,'" + Interaction + "', " + unPrix + ", " + unPrixEchantillon + ",'" + Presentation + "')", monDAOFactory.connexionBDD);

                SqlDataReader ExecuterCreation = monSQLCommand.ExecuteReader();

                MessageBox.Show("Produit Créer");
                ExecuterCreation.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


            monDAOFactory.CloseConnection();





        }
        public static ArrayList TTproduit()
        {

            String requete = "select * from produit";
            ArrayList resultat = new ArrayList();
            DAOFactory brd = new DAOFactory();
            brd.OuvrirConnexion();
            SqlCommand monSQLCommand = new SqlCommand(requete, brd.connexionBDD);
            SqlDataReader rs = monSQLCommand.ExecuteReader();

            while (rs.HasRows)
            {
                resultat.Add(new Produit(rs.GetString(0), rs.GetString(2)));
                brd.CloseConnection();
            }

            return resultat;
        }
    }
}
    