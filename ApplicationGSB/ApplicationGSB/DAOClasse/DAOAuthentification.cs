using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ApplicationGSB
{
    class DAOAuthentification
    {
        public List<Auth> getAllCompte()
        {
            List<Auth> resultat = new List<Auth>();
            try
            {
                DAOFactory DAOF = new DAOFactory();
                DAOF.connexion();
                String requete = "select * from Authentification;";
                SqlDataReader DR = DAOF.execRead(requete);
                while (DR.Read())
                {
                    resultat.Add(new Auth(DR.GetString(1), DR.GetString(2)));
                }
                DAOF.deconnexion();
                return resultat;
            }
            catch (Exception)
            {
                throw new Exception("Ne marche pas");
            }
        }
    }
}
