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
    public partial class frm_Application : Form
    {
        #region Variables Globales
        DAOFactory DAOF = new DAOFactory();
        DAOVisiteursMedicaux DAOVM = new DAOVisiteursMedicaux();
        #endregion
        public frm_Application()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            DAOF.connexion();
            string requete = "INSERT INTO Produits (effetTherapeutique,nomProduit,contreIndication,pxVenteHT,pxEchantillon,dosage,presentation,idFamille)";
            requete = requete + "VALUES ('"+ txbEffetsTherapeu.Text + "','" + cbxMedicaments.Text + "','" + txtbContreInd.Text + "','" + float.Parse(txtbPxVenteHT.Text) + "','" + float.Parse(txtbPxEchantillon.Text) + "','" + txtbDosage.Text + "','" + txtbPresentation.Text + "','" + Int32.Parse(txtbFamille.Text) + "');";
            DAOF.execWrite(requete);
            DAOF.deconnexion();
        }

        private void btnCreerVisiteur_Click(object sender, EventArgs e)
        {

        }

        private void tabVisiteursMedicaux_Enter(object sender, EventArgs e)
        {
            List<VisiteursMedicaux> lesVisiteursMedicaux = new List<VisiteursMedicaux>();
            lesVisiteursMedicaux = DAOVM.getAllVisiteursMedicaux();
            dgvVisiteurMedical.DataSource = lesVisiteursMedicaux;
            dgvVisiteurMedical.AutoResizeColumns();
        }
    }
}
