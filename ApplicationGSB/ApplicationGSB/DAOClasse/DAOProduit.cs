using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationGSB
{
    class DAOProduit
    {
        public List<Produit> getAllProduits()
        {
            List<Produit> resultatProduit = new List<Produit>();
            try
            {
                String req = "select * from Produit";
                DAOFactory db = new DAOFactory();
                SqlDataReader DR = db.execRead(req);
                while(DR.NextResult())
                {
                    resultatProduit.Add(new Produit(DR.GetString(0), DR.GetString(1), DR.GetString(2), DR.GetString(3), DR.GetString(4), DR.GetInt32(5),
                        DR.GetFloat(6), DR.GetFloat(7)));
                }
                return resultatProduit;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
