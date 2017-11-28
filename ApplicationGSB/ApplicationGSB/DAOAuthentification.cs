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
        public List<Auth> getAllCompte ()
        {
            List<Auth> resultat = new List<Auth>();
            try
            {
                String requete = "select * from Authentification";
                DAOFactory db = new DAOFactory();
                SqlDataReader DR = db.execRead(requete);
                while (DR.NextResult())
                {
                    resultat.Add(new Auth(DR.GetString(0), DR.GetString(1)));
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
