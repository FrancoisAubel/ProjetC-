using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackOfficeCommercial
{
    public partial class GestionProduit : Form
    {
        public GestionProduit()
        {
            InitializeComponent();
        }

        private void btn_Del_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Edit_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_New_BackHomeProd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Bouton Valider avec condition si tous est remplie.
        private void btn_New_ValiderProd_Click(object sender, EventArgs e)
        {
            if (txb_New_NomCommercialProd.Text.ToString() == "" || txb_New_DosageProd.Text.ToString() == "" || cb_New_FamilleProd.Text.ToString() == "" ||
                txb_New_Numero.Text.ToString() == "" || txb_New_PrixProd.Text.ToString() == "")
            {
                MessageBox.Show("L'un des champs n'a pas été remplie : Numéro, Dosage, Famille, Nom Commercial, Prix. Bouton Valider impossible");
            }
            else
            {
                DAOProduit monDAOProduit = new DAOProduit();
                String unPrix = txb_New_PrixProd.Text.ToString().Replace('.', ',');
                String unPrixEchant = txb_New_PrixEchant.Text.ToString().Replace('.', ',');
                monDAOProduit.NouveauProduit(txb_New_Numero.Text.ToString(), txb_New_DosageProd.Text.ToString(), cb_New_FamilleProd.Text.ToString(), txb_New_NomCommercialProd.Text.ToString(),
                double.Parse(unPrix), txb_New_ContreIndications.Text.ToString(), txb_New_EffetsTherapeutiques.Text.ToString(), txb_New_Interactions.Text.ToString(), double.Parse(unPrixEchant), txb_New_Presentation.Text.ToString());
                cb_Del_NomCommercial.Items.Add(txb_New_NomCommercialProd.Text.ToString());
                cb_Edit_NomCommercial.Items.Add(txb_New_NomCommercialProd.Text.ToString());

                Vider_Contenue_New();
                
            }
        }
        // Code du changement d'index dans la combobox de l'onglet supprimer.
        private void btn_New_Annuler_Click(object sender, EventArgs e)
        {
            Vider_Contenue_New();
        }
        private void cb_Del_NumeroProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAOProduit VarIndChange = new DAOProduit();
            txb_Del_NomCommercialProd.Text = VarIndChange.RecupererValeur("Numero", cb_Del_NomCommercial.Text);
            txb_Del_PrixProd.Text = (VarIndChange.RecupererValeurDouble("PrixVente", cb_Del_NomCommercial.Text)).ToString();
            txb_Del_PrixEchant.Text = (VarIndChange.RecupererValeurDouble("PrixEchantillon", cb_Del_NomCommercial.Text)).ToString();
            txb_Del_DosageProd.Text = VarIndChange.RecupererValeur("Dosage", cb_Del_NomCommercial.Text);
            txb_Del_FamilleProd.Text = VarIndChange.RecupererValeurFamille("IdFamille", cb_Del_NomCommercial.Text);
            rch_Del_ContreIndications.Text = VarIndChange.RecupererValeur("ContreIndication", cb_Del_NomCommercial.Text);
            rch_Del_EffetsTherapeutiques.Text = VarIndChange.RecupererValeur("EffetTherapeutique", cb_Del_NomCommercial.Text);
            rch_Del_Interactions.Text = VarIndChange.RecupererValeur("Interactions", cb_Del_NomCommercial.Text);
            rch_Del_Presentation.Text = VarIndChange.RecupererValeur("Presentation", cb_Del_NomCommercial.Text);

        }

        private void cb_Edit_NumeroProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAOProduit VarIndChange = new DAOProduit();
            txb_Edit_Numero.Text = VarIndChange.RecupererValeur("Numero", cb_Edit_NomCommercial.Text);
            txb_Edit_PrixProd.Text = (VarIndChange.RecupererValeurDouble("PrixVente", cb_Edit_NomCommercial.Text)).ToString();
            txb_Edit_PrixEchant.Text = (VarIndChange.RecupererValeurDouble("PrixEchantillon", cb_Edit_NomCommercial.Text)).ToString();
            txb_Edit_DosageProd.Text = VarIndChange.RecupererValeur("Dosage", cb_Edit_NomCommercial.Text);
            cb_Edit_FamilleProd.Text = VarIndChange.RecupererValeurFamille("IdFamille", cb_Edit_NomCommercial.Text);
            txb_Edit_ContreIndications.Text = VarIndChange.RecupererValeur("ContreIndication", cb_Edit_NomCommercial.Text);
            txb_Edit_EffetsTherapeutiques.Text = VarIndChange.RecupererValeur("EffetTherapeutique", cb_Edit_NomCommercial.Text);
            txb_Edit_Interactions.Text = VarIndChange.RecupererValeur("Interactions", cb_Edit_NomCommercial.Text);
            txb_Edit_Presentation.Text = VarIndChange.RecupererValeur("Presentation", cb_Edit_NomCommercial.Text);
        }


        private void btn_Edit_ModifierProd_Click(object sender, EventArgs e)
        {
            if (cb_Edit_NomCommercial.ToString() == "" || txb_Edit_DosageProd.ToString() == "" || cb_Edit_FamilleProd.ToString() == "" ||
    txb_Edit_Numero.ToString() == "" || txb_Edit_PrixProd.ToString() == "")
            {
                MessageBox.Show("L'un des champs n'a pas été remplie : Numéro, Dosage, Famille, Nom Commercial, Prix. Bouton Valider impossible");
            }
            else
            {
                try
                {
                    DAOProduit monDAOProduit = new DAOProduit();
                    String unPrix = txb_Edit_PrixProd.Text.ToString().Replace('.', ',');
                    String unPrixEchant = txb_Edit_PrixEchant.Text.ToString().Replace('.', ',');
                    monDAOProduit.EditProduit(txb_Edit_Numero.Text.ToString(), txb_Edit_DosageProd.Text.ToString(), cb_Edit_FamilleProd.Text.ToString(), cb_Edit_NomCommercial.Text.ToString(),
                    double.Parse(unPrix), txb_Edit_ContreIndications.Text.ToString(), txb_Edit_EffetsTherapeutiques.Text.ToString(), txb_Edit_Interactions.Text.ToString(), double.Parse(unPrixEchant), txb_Edit_Presentation.Text.ToString());

                    Vider_Contenue_Edit();
                    Vider_Contenue_Del();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Btn_Edit_Annuler_Click(object sender, EventArgs e)
        {
            Vider_Contenue_Edit();
        }

        private void btn_Del_SupprimerProd_Click(object sender, EventArgs e)
        {
            if (cb_Del_NomCommercial.Text == "")
            {
                MessageBox.Show("Le numéro de produit n'est pas renseigné");
            }
            else
            {
                DAOProduit unDAOProduit = new DAOProduit();

                String unNombre = cb_Del_NomCommercial.Text;
                unDAOProduit.SupprimerProduit(cb_Del_NomCommercial.Text);
                cb_Del_NomCommercial.Items.Remove(unNombre);
                cb_Edit_NomCommercial.Items.Remove(unNombre);
                Vider_Contenue_Del();

                Vider_Contenue_Edit();
      
            }
        }

        private void Btn_Del_Annuler_Click(object sender, EventArgs e)
        {

            Vider_Contenue_Del();
        }
        // 1 ) Evenement lancemement de l'interface Produit.
        // Récupération des famille grâce à une lsit famille
        private void GestionProduit_Load(object sender, EventArgs e)
        {

            // Remplissage de la Combobox de l'onglet "new" et "Edit"
            Famille uneFamille = new Famille();
            List<Famille> lesFamilles = new List<Famille>();
            lesFamilles = uneFamille.RecupererlesFamille();
            for (int i = 0; i < lesFamilles.Count; i++)
            {
                cb_New_FamilleProd.Items.Add(lesFamilles.ElementAt(i).UnNom);
                cb_Edit_FamilleProd.Items.Add(lesFamilles.ElementAt(i).UnNom);
            }

            // Remplissage des Numéro de l'onglet " Edit" et "delete"

            DAOProduit unProduit = new DAOProduit();
            List<Produit> lesProduits = new List<Produit>();
            lesProduits = unProduit.RecupererNomCommercial();
            int nbProbuit = lesProduits.Count;
              for (int i = 0; i < nbProbuit; i++)
            {
                cb_Edit_NomCommercial.Items.Add(lesProduits.ElementAt(i).UnNomCommercial);
                cb_Del_NomCommercial.Items.Add(lesProduits.ElementAt(i).UnNomCommercial);
             }

            

        }

        // Verification que le nom Commercial n'est pas déjà prit

        private void txb_New_NomCommercial_Leave(object sender, EventArgs e)
        {
            DAOProduit unDAOProduit = new DAOProduit();
            if (unDAOProduit.VerificationNomCommercial(txb_New_NomCommercialProd.Text.ToString()))
            {
                MessageBox.Show("Le nom Commercial est déjà prit");
                txb_New_NomCommercialProd.Text = "";
            }
        }

        private void txb_New_Numero_Leave(object sender, EventArgs e)
        {
            DAOProduit unDAOProduit = new DAOProduit();
            if (unDAOProduit.VerificationNumero(txb_New_Numero.Text.ToString()))
            {
                MessageBox.Show("Le numéro est déjà prit");
                txb_New_Numero.Text = "";
            }
        }

        public void Vider_Contenue_Del()
        {
            cb_Del_NomCommercial.Text = "";
            txb_Del_NomCommercialProd.Text = "";
            txb_Del_PrixProd.Text = "";
            txb_Del_DosageProd.Text = "";
            txb_Del_FamilleProd.Text = "";
            rch_Del_ContreIndications.Text = "";
            rch_Del_EffetsTherapeutiques.Text = "";
            rch_Del_Interactions.Text = "";
            txb_Del_PrixEchant.Text = "";
            rch_Del_Presentation.Text = "";
        }

        public void Vider_Contenue_Edit()
        {
            cb_Edit_NomCommercial.Text = "";
            txb_Edit_Numero.Text = "";
            txb_Edit_PrixProd.Text = "";
            txb_Edit_DosageProd.Text = "";
            cb_Edit_FamilleProd.Text = "";
            txb_Edit_ContreIndications.Text = "";
            txb_Edit_EffetsTherapeutiques.Text = "";
            txb_Edit_Interactions.Text = "";
            txb_Edit_PrixEchant.Text = "";
            txb_Edit_Presentation.Text = "";
        }
        public void Vider_Contenue_New()
        {
            txb_New_NomCommercialProd.Text = "";
            txb_New_Numero.Text = "";
            txb_New_PrixProd.Text = "";
            txb_New_DosageProd.Text = "";
            cb_New_FamilleProd.Text = "";
            txb_New_ContreIndications.Text = "";
            txb_New_EffetsTherapeutiques.Text = "";
            txb_New_Interactions.Text = "";
            txb_New_PrixEchant.Text = "";
            txb_New_Presentation.Text = "";
        }





























        private void txb_New_NumeroProd_Leave(object sender, EventArgs e)
        {

        }

        private void tb_GestionProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tb_GestionProd_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void tb_GestionProd_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void cb_New_FamilleProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gb_New_NouveauProduit_Enter(object sender, EventArgs e)
        {

        }

        private void tab_NouveauProd_Click(object sender, EventArgs e)
        {

        }

        private void lbl_New_NumeroProd_Click(object sender, EventArgs e)
        {

        }

        private void gb_Del_Interactions_Enter(object sender, EventArgs e)
        {

        }

  












    }
}
