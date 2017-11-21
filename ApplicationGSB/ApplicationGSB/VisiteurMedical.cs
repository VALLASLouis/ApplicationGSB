using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class VisiteurMedical
    {
        #region Propriétés
        private String nomVisiteurs;
        private String code;
        private String ville;
        private String dateNaissance;
        private int CP;
        private String nomSecteur;
        #endregion

        #region Accesseurs
        public string NomVisiteurs
        {
            get
            {
                return nomVisiteurs;
            }
        }


        public string Code
        {
            get
            {
                return code;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }
        }

        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }
        }

        public string CP1
        {
            get
            {
                return CP1;
            }
        }

        public string NomSecteur
        {
            get
            {
                return nomSecteur;
            }
        }
        #endregion
    }
}
}
