using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class DAOVisiteursMedicaux
    {
        public List<VisiteursMedicaux> getAllVisiteursMedicaux()
        {
            List<VisiteursMedicaux> resultatVis = new List<VisiteursMedicaux>();
            try
            {
                DAOFactory DAOF = new DAOFactory();
                DAOF.connexion();
                String req = "select * from visiteursMedicaux;";  
                SqlDataReader DR = DAOF.execRead(req);
                while(DR.Read())
                {
                    resultatVis.Add(new VisiteursMedicaux(DR.GetString(1), DR.GetString(2), DR.GetString(3),
                        DR.GetString(4), DR.GetInt32(5), DR.GetString(6)));
                }
                DAOF.deconnexion();
                return resultatVis;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
