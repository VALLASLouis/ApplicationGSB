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
       
        public List<classeAuthentification> getAllCompte ()
        {
            List<classeAuthentification> resultat = new List<classeAuthentification>();
            try
            {
                DAOFactory DAOA = new DAOFactory();
                DAOA.connexion();
                String requete = "select * from authentification;";
                SqlDataReader DR = DAOA.execRead(requete);
                while (DR.NextResult())
                {
                    resultat.Add(new classeAuthentification(DR.GetString(0), DR.GetString(1)));
                }
                DAOA.deconnexion();
                return resultat;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
