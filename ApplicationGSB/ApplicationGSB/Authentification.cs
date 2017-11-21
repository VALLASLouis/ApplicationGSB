using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGSB
{
    public partial class frmAuthentification : Form
    {
        public frmAuthentification()
        {
            InitializeComponent();
        }

        #region Propriétés
        DAOAuthentification DAOA = new DAOAuthentification();
        #endregion


        #region Stock inutile
        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Fonction
        public Boolean verifCompte (String unLogin, String unPassword)
        {
            try
            {
                bool montest = false;
                List<classeAuthentification> lesComptes = new List<classeAuthentification>();
                lesComptes = DAOA.getAllCompte();
                for (int i = 0; i < lesComptes.Count; i++)
                {
                    if (lesComptes[i].Login == unLogin && lesComptes[i].Password == unPassword)
                    {
                        montest = true;                      
                    }
                }
                return montest;
            }
           catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            
        }
        #endregion

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if(verifCompte(txtbLogin.Text, txtbPassword.Text)){
                lblMsgErreurAuth.Text = "Connexion validée";
                frmAuthentification formAuth = new frmAuthentification();
                formAuth.Hide();
                frm_Application formApp = new frm_Application();
                formApp.Show();
            }
            else
            {
                lblMsgErreurAuth.Text = "Connexion refusée, pour créer un nouveau compte, veuillez vous adressez à l'administrateur.";
            }
        }
    }
}
