using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class Produit
    {
        #region Propriétés

        private String effetTherapeutique;
        private String nomProduit;
        private String contreIndication;
        private String dosage;
        private String presentation;
        private int idFamille;
        private float pxVenteHT;
        private float pxEchantillon;

        #endregion

        #region Accesseurs
        public string EffetTherapeutique
        {
            get
            {
                return effetTherapeutique;
            }
        }

        public string NomProduit
        {
            get
            {
                return nomProduit;
            }
        }

        public string ContreIndication
        {
            get
            {
                return contreIndication;
            }
        }

        public string Dosage
        {
            get
            {
                return dosage;
            }
        }

        public string Presentation
        {
            get
            {
                return presentation;
            }
        }

        public int IdFamille
        {
            get
            {
                return idFamille;
            }
        }

        public float PxVenteHT
        {
            get
            {
                return pxVenteHT;
            }
        }

        public float PxEchantillon
        {
            get
            {
                return pxEchantillon;
            }
        }

        #endregion

        public Produit(String unEffetTherapeutique, String unNomProduit, String uneContreIndication, String unDosage, String unePresentation, int unIdFamille, float unPxVenteHT, float unPxEchantillon)
        {
            effetTherapeutique = unEffetTherapeutique;
            nomProduit = unNomProduit;
            contreIndication = uneContreIndication;
            dosage = unDosage;
            presentation = unePresentation;
            idFamille = unIdFamille;
            pxVenteHT = unPxVenteHT;
            pxEchantillon = unPxEchantillon;
        }
    }
}
