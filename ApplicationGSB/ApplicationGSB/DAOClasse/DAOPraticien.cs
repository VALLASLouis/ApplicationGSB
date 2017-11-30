using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ApplicationGSB
{
    class DAOPraticien
    {
        public List<Praticien> getAllPraticien()
        {
            List<Praticien> resultatPraticien = new List<Praticien>();
            try
            {
                String req = "select * from Praticien";
                DAOFactory database = new DAOFactory();
                SqlDataReader DR = database.execRead(req);
                while(DR.NextResult())
                {
                    resultatPraticien.Add(new Praticien(DR.GetString(0), DR.GetString(1), DR.GetString(2), DR.GetString(3), DR.GetString(4),
                        DR.GetString(5), DR.GetString(6), DR.GetString(7), DR.GetString(8), DR.GetString(9)));
                }
                return resultatPraticien;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
