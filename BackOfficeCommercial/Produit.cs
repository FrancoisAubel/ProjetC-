using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackOfficeCommercial
{
    class Produit
    {
        String unNumero;
        String unDosage;
        String uneFamille;
        String unNomCommercial;
        String uneContreIndication;
        String unEffet;
        double unPrix;
        String uneInteraction;
        double unPrixEchantillon;
        String unePresentation;

        public String UnNumero
        {
            get { return unNumero; }
            set { unNumero = value; }
        }
        

        public String UnDosage
        {
            get { return unDosage; }
            set { unDosage = value; }
        }
        

        public String UneFamille
        {
            get { return uneFamille; }
            set { uneFamille = value; }
        }
        

        public String UnNomCommercial
        {
            get { return unNomCommercial; }
            set { unNomCommercial = value; }
        }
        
        public double UnPrix
        {
            get { return unPrix; }
            set { unPrix = value; }
        }
        

        public String UneContreIndication
        {
            get { return uneContreIndication; }
            set { uneContreIndication = value; }
        }
        

        public String UnEffet
        {
            get { return unEffet; }
            set { unEffet = value; }
        }
        

        public String UneInteraction
        {
            get { return uneInteraction; }
            set { uneInteraction = value; }
        }
        
        public double UnPrixEchantillon
        {
            get { return unPrixEchantillon; }
            set { unPrixEchantillon = value; }
        }
        

        public String UnePresentation
        {
            get { return unePresentation; }
            set { unePresentation = value; }
        }

        List<String> Famille = new List<String>();


        public Produit(String Numero, String Dosage, String NomCommercial, String Effet,
            String ContreIndication, String Famille,String Interaction, double Prix, double PrixEchantillon, String Presentation)
        {
            unNumero = Numero;
            unDosage = Dosage;
            unNomCommercial = NomCommercial;
            unEffet = Effet;
            uneContreIndication = ContreIndication;
            uneFamille = Famille;
            uneInteraction = Interaction;
            unPrix = Prix;           
            unPrixEchantillon = PrixEchantillon;
            unePresentation = Presentation;
       

        }

        public Produit()
        {
        }

        public Produit(String uneRef, String uneDesignation)
        {
            unNumero = uneRef;
            unNomCommercial = uneDesignation;
        }

 

    }
}
