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
                String requete = "select * from Authentification";
                DAOFactory db = new DAOFactory();
                SqlDataReader DR = db.execRead(requete);
                while (DR.NextResult())
                {
                    resultat.Add(new classeAuthentification(DR.GetString(0), DR.GetString(1)));
                }
                return resultat;
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
