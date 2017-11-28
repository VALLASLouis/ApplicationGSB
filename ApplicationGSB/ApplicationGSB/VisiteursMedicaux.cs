using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class VisiteursMedicaux
    {
        #region Propriétés
        private String nomVisiteur;
        private String code;
        private String ville;
        private String dateNaissance;
        private int CP;
        private String nomSecteur;
        #endregion

        #region Accesseurs
        public string NomVisiteur
        {
            get
            {
                return nomVisiteur;
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

        public int CP1
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

        public VisiteursMedicaux(String unNomVisiteur, String unCode, String uneVille, String uneDateNaissance, int unCP, String unNomSecteur)
        {
            nomVisiteur = unNomVisiteur;
            code = unCode;
            ville = uneVille;
            dateNaissance = uneDateNaissance;
            CP = unCP;
            nomSecteur = unNomSecteur;
        }
    }
}
