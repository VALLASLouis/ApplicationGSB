using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class classePraticiens
    {
        #region Propriétés
        private String codePraticien;
        private String raisonSociale;
        private String adresse;
        private String telephone;
        private String nom;
        private String mail;
        private bool client_O_N;
        private int coefNotoriete;
        private int coefConfiance;
        private String nomSpecialite;
        #endregion

        #region Accesseurs
        public string CodePraticien
        {
            get
            {
                return codePraticien;
            }
        }

        public string RaisonSociale
        {
            get
            {
                return raisonSociale;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }
        }

        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }
        }

        public bool Client_O_N
        {
            get
            {
                return client_O_N;
            }
        }

        public int CoefNotoriete
        {
            get
            {
                return coefNotoriete;
            }
        }

        public int CoefConfiance
        {
            get
            {
                return coefConfiance;
            }
        }

        public string NomSpecialite
        {
            get
            {
                return nomSpecialite;
            }
        }

        #endregion


    }
}
