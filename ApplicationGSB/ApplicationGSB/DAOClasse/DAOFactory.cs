using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ApplicationGSB
{
    class DAOFactory
    {
        #region Variables globales

        SqlConnection maConnexion;
        SqlDataAdapter monDataAdapter;
        SqlCommand maRequete;
        SqlDataReader monDR;
        private const String urlAcces = "Data Source ='172.17.21.10';Initial Catalog=SIO2_GSB_TeamE;User ID=SIO2-dev;Password=btssio-slam-2018";

        #endregion

        public DAOFactory()
        {

        }

        public void connexion()
        {
            maConnexion = new SqlConnection(urlAcces);
            maConnexion.Open();
        }

        public void deconnexion()
        {
            maConnexion.Close();
        }

        public SqlDataReader execRead(String requete)
        {
            //Instancier la requête
            maRequete = new SqlCommand();
            maRequete.CommandText = requete;
            maRequete.Connection = maConnexion;

            // Formater la requête SQL pour l'executer
            monDataAdapter = new SqlDataAdapter();
            monDataAdapter.SelectCommand = maRequete;


            // On exécute la requête
            monDR = maRequete.ExecuteReader();

            // Retourne le DR
            return monDR;
        }

        public void execWrite(String requete)
        {
            try
            {
                //Instancier la requête
                maRequete = new SqlCommand();
                maRequete.CommandText = requete;
                maRequete.Connection = maConnexion;

                // Formater la requête SQL pour l'executer
                //monDataAdapter = new SqlDataAdapter();
               // monDataAdapter.SelectCommand = maRequete;


                // On exécute la requête
                maRequete.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
