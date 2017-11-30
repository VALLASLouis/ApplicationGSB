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
        public frm_Application()
        {
            InitializeComponent();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
           string requete = "INSERT INTO \"livre-LV\" (idProduit,effetTherapeutique,nomProduit,contreIndication,pxVenteHT,pxEchantillon,dosage,presentation,idFamille)";
           requete = requete + "VALUES ('" + txbIdProduit.Text + "','" + txbEffetsTherapeu + "','" + cbxMedicaments.Text + "','" + txtbContreInd.Text + "','" + txtbPxVenteHT.Text + "','" + txtbPxEchantillon.Text + "','" + txtbDosage.Text + "','" + txtbPresentation + "','" + txtbFamille.Text +"';'";

        }
    }
}
