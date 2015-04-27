using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    public partial class GestionClient : Form
    {
        List<Client> lesClients; // Création d'une List LesClients
        List<Visiteur> lesVisiteurs; // Création d'une List LesVisiteurs

        public GestionClient()
        {
            InitializeComponent();
        }

        public void chargerLesClients()
        {
            #region Création de la liste lesClients contenant les clients de la base de données
            lesClients = new List<Client>(); // On initialise la List
            DAOClient monDaoClient = new DAOClient(); // On crée un objet DAOClient
            lesClients = monDaoClient.recupererLesClients(); // On fait appel à la méthode recupererLesClients du DAOClient
            #endregion

            #region Ajout du nom des clients à la collection de la combobox Client
            for (int i = 0; i < lesClients.Count(); i++)
            {
                cb_Edit_NomCli.Items.Add(lesClients[i].Nom.ToString()); // Permet d'afficher les clients dans la combobox (ONGLET MODIFICATION)
                cb_Del_NomCli.Items.Add(lesClients[i].Nom.ToString()); // Permet d'afficher les clients dans la combobox (ONGLET SUPPRESSION)
            }
            #endregion
        } // Procédure permettant de récupérer les clients stockées en BDD

        private void GestionClient_Load(object sender, EventArgs e)
        {

            chargerLesClients(); // Appel de la procédure chargerLesClients()
            DAOClient monDaoClient = new DAOClient(); // Création d'un objet DAOClient

            #region Ajout des types de clients à la collection de la combobox cbxRaisonClient
            /*cb_Edit_NomCli.Items.Add("Médecin");
            cb_Edit_NomCli.Items.Add("Chômeur");
            cb_Edit_NomCli.Items.Add("Chirurgien");*/
            #endregion

            #region Tests
            // MessageBox.Show((monDaoClient.trouverNomProfessionParId(1)));
            // MessageBox.Show((monDaoClient.trouverIdProfessionnelParNomProfession("Cadre").ToString()));

            /* List<Visiteur> lesVisiteurs = new List<Visiteur>();
            Visiteur V1 = new Visiteur(1, "Dylan", "Bob");
            Visiteur V2 = new Visiteur(2, "Piat", "Gregoire");
            lesVisiteurs.Add(V1);
            lesVisiteurs.Add(V2);*/
            #endregion
        } // Charge les clients au démarrage de l'application en faisant appel à chargerLesClients()

        private void btn_Del_BackHomeCli_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Permet de prendre en compte le clique du bouton "Retour accueil"

        private void btn_Edit_BackHomeCli_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Permet de prendre en compte le clique du bouton "Retour accueil"

        private void btn_New_BackHomeCli_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Permet de prendre en compte le clique du bouton "Retour accueil"



        private void btn_New_Rdv_Click(object sender, EventArgs e)
        {
            if (txb_New_HeuresRdv.Text != "" || txb_New_MinutesRdv.Text != "" || rch_New_CompteRenduCli.Text != "" || txb_New_Visiteur.Text != "")
            {
                string heureConcat = txb_New_HeuresRdv.Text + " : " + txb_New_MinutesRdv.Text;

                string[] row = new string[] { calendar_New_DateRdv.Text, heureConcat, txb_New_Visiteur.Text, rch_New_CompteRenduCli.Text };
                dtg_New_DateRDVCli.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        } // Gère l'ajout d'un nouveau rendez-vous

        private void cb_Edit_NomCli_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lesClients.Count(); i++)
            {
                DAOClient monDaoClientTXB = new DAOClient();
                if (lesClients[i].Nom.ToString() == cb_Edit_NomCli.Text)
                {
                    Client leClient = lesClients[i];
                    cb_Edit_NomCli.Text = leClient.Nom.ToString();
                    txb_Edit_CodeCli.Text = leClient.Id.ToString();
                    txb_Edit_RaisonSocialCli.Text = leClient.RaisonSociale.ToString();
                    txb_Edit_AdresseCli.Text = leClient.Adresse.ToString();
                    //txb_Edit_TypeCli.Text = monDaoClientTXB.trouverNomProfessionParId(leClient.IdTypeProfessionnel).Trim();
                    txb_Edit_TypeCli.Text = leClient.IdTypeProfessionnel.ToString();
                    txb_Edit_MailCli.Text = leClient.Email.ToString();
                    txb_Edit_VilleCli.Text = leClient.Ville.ToString();
                    txb_Edit_PrenomCli.Text = leClient.Prenom.ToString();
                    txb_Edit_CodePostalCli.Text = leClient.Cp.ToString();
                    txb_Edit_TelephoneCli.Text = leClient.Telephone.ToString();
                    /////////////////////////////////////
                    /////////////////////////////////////
                    /////////////////////////////////////
                }
            }
        } // Permet d'afficher les informations associées à la personne sélectionnée

        private void cb_Del_NomCli_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lesClients.Count(); i++)
            {
                DAOClient monDaoClientTXB = new DAOClient();
                if (lesClients[i].Nom.ToString() == cb_Del_NomCli.Text)
                {
                    Client leClient = lesClients[i];
                    cb_Del_NomCli.Text = leClient.Nom.ToString();
                    txb_Del_CodeCli.Text = leClient.Id.ToString();
                    txb_Del_RaisonSocialCli.Text = leClient.RaisonSociale.ToString();
                    txb_Del_AdresseCli.Text = leClient.Adresse.ToString();
                    //txb_Del_TypeCli.Text = monDaoClientTXB.trouverNomProfessionParId(leClient.IdTypeProfessionnel);
                    txb_Del_TypeCli.Text = leClient.IdTypeProfessionnel.ToString();
                    txb_Del_MailCli.Text = leClient.Email.ToString();
                    txb_Del_VilleCli.Text = leClient.Ville.ToString();
                    txb_Del_PrenomCli.Text = leClient.Prenom.ToString();
                    txb_Del_CpCli.Text = leClient.Cp.ToString();
                }
            }

        } // Permet d'afficher les informations associées à la personne sélectionnée



        private void btn_New_ValiderCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    txb_New_CodeCli.Text != ""
                    || txb_New_NomCli.Text != ""
                    || txb_New_PrenomCli.Text != ""
                    || txb_New_RaisonSocialCli.Text != ""
                    || txb_New_VilleCli.Text != ""
                    || txb_New_AdresseCli.Text != ""
                    || txb_New_CodePostal.Text != ""
                    || txb_New_MailCli.Text != ""
                    || txb_New_TypeCli.Text != ""
                    || txb_New_TelephoneCli.Text != ""
                    )
                {
                    DAOClient.ajouterClient(int.Parse(txb_New_CodeCli.Text), txb_New_NomCli.Text, txb_New_PrenomCli.Text, txb_New_RaisonSocialCli.Text, txb_New_VilleCli.Text, txb_New_AdresseCli.Text, txb_New_CodePostal.Text,
                    txb_New_MailCli.Text, int.Parse(txb_New_TypeCli.Text), txb_New_TelephoneCli.Text);
                    cb_Edit_NomCli.Items.Add(txb_New_NomCli.Text);
                    MessageBox.Show("Ajout effectuée !");
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Un problème est survenu : " + exe.ToString());
            }


        } // Gère l'ajout de la personne en faisant appel à la méthode de DAOClient (ajouterClient)

        private void btn_Edit_ValiderCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                   txb_Edit_CodeCli.Text != ""
                   || cb_Edit_NomCli.Text != ""
                   || txb_Edit_PrenomCli.Text != ""
                   || txb_Edit_RaisonSocialCli.Text != ""
                   || txb_Edit_VilleCli.Text != ""
                   || txb_Edit_AdresseCli.Text != ""
                   || txb_Edit_CodePostalCli.Text != ""
                   || txb_Edit_MailCli.Text != ""
                   || txb_Edit_TypeCli.Text != ""
                   )
                {
                    DAOClient.modifierClient(int.Parse(txb_Edit_CodeCli.Text), cb_Edit_NomCli.Text, txb_Edit_PrenomCli.Text, txb_Edit_RaisonSocialCli.Text, txb_Edit_VilleCli.Text, txb_Edit_AdresseCli.Text, txb_Edit_CodePostalCli.Text,
                    txb_Edit_MailCli.Text, int.Parse(txb_Edit_TypeCli.Text), txb_Edit_TelephoneCli.Text);
                    MessageBox.Show("Edtion effectuée !");
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs");
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Un problème est survenu " + exe.ToString());
            }


        } // Gère la modification de la personne en faisant appel à la méthode de DAOClient (modifierClient)

        private void btn_Del_ValiderCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_Del_NomCli.Text != "" && txb_Del_PrenomCli.Text != "" && txb_Del_CodeCli.Text != "")
                {
                    DAOClient.supprimerClient(int.Parse(txb_Del_CodeCli.Text), cb_Del_NomCli.Text, txb_Del_PrenomCli.Text);
                }

            }
            catch (Exception exe)
            {
                MessageBox.Show("Un problème est survenu : " + exe.ToString());
            }
            MessageBox.Show("Suppression effectuée !");
        } // Gère la suppression de la personne en faisant appel à la méthode de DAOClient (supprimerClient)

        #region Bin

        private void gb_Del_DateRDVCli_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void txb_Edit_CodeCli_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_New_CodePostal_Click(object sender, EventArgs e)
        {

        }
        private void dtg_New_DateRDVCli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void gb_New_DateRDVCli_Enter(object sender, EventArgs e)
        {

        }
        private void calend_New_DateRDVCli_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        private void cb_Edit_NomCli_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion // Corbeille
    }
}