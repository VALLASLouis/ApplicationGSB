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
                String req = "select * from VisiteursMedicaux";
                DAOFactory db = new DAOFactory();
                SqlDataReader DR = db.execRead(req);
                while(DR.NextResult())
                {
                    resultatVis.Add(new VisiteursMedicaux(DR.GetString(0), DR.GetString(1), DR.GetString(2),
                        DR.GetString(3), DR.GetInt32(4), DR.GetString(5)));
                }
                return resultatVis;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
