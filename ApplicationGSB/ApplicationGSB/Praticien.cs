using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class Praticien
    {
        #region Propriétés
        String nom;
        String code;
        String specialite;
        String raisonSociale;
        String adresse;
        String telephone;
        String mail;
        String client;
        String coefConf;
        String coefNot;

        #endregion

        #region Accesseurs
        public string Nom
        {
            get
            {
                return nom;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }
        }

        public string Specialite
        {
            get
            {
                return specialite;
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

        public string Mail
        {
            get
            {
                return mail;
            }
        }

        public string Client
        {
            get
            {
                return client;
            }
        }

        public string CoefConf
        {
            get
            {
                return coefConf;
            }
        }

        public string CoefNot
        {
            get
            {
                return coefNot;
            }
        }
        #endregion

        public Praticien(string nom, string code, string specialite, string raisonSociale, string adresse, string telephone, string mail, string client, string coefConf, string coefNot)
        {
            this.nom = nom;
            this.code = code;
            this.specialite = specialite;
            this.raisonSociale = raisonSociale;
            this.adresse = adresse;
            this.telephone = telephone;
            this.mail = mail;
            this.client = client;
            this.coefConf = coefConf;
            this.coefNot = coefNot;
        }

    }
}
