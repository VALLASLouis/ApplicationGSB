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
        private String CP;
        private int idSecteur;

       
        #endregion

        #region Accesseurs

         public string NomVisiteur
        {
            get
            {
                return nomVisiteur;
            }

            set
            {
                nomVisiteur = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Ville
        {
            get
            {
                return ville;
            }

            set
            {
                ville = value;
            }
        }

        public string DateNaissance
        {
            get
            {
                return dateNaissance;
            }

            set
            {
                dateNaissance = value;
            }
        }


        public int IdSecteur
        {
            get
            {
                return idSecteur;
            }

            set
            {
                idSecteur = value;
            }
        }

        public string CP1
        {
            get
            {
                return CP;
            }

            set
            {
                CP = value;
            }
        }

        #endregion

        public VisiteursMedicaux(String unNomVisiteur, String unCode, String uneVille, String uneDateNaissance, int unIdSecteur, String unCP)
        {
            NomVisiteur = unNomVisiteur;
            Code = unCode;
            Ville = uneVille;
            DateNaissance = uneDateNaissance;
            CP = unCP;
            IdSecteur = unIdSecteur;
        }
    }
}
