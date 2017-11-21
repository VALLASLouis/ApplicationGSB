namespace ApplicationGSB
{
    partial class frm_Application
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabApplication = new System.Windows.Forms.TabControl();
            this.tabMedicament = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.lblPresentation = new System.Windows.Forms.Label();
            this.lblPxEchantillon = new System.Windows.Forms.Label();
            this.lblPxHT = new System.Windows.Forms.Label();
            this.lblFamille = new System.Windows.Forms.Label();
            this.txtbPxEchantillon = new System.Windows.Forms.TextBox();
            this.txtbPresentation = new System.Windows.Forms.TextBox();
            this.txtbFamille = new System.Windows.Forms.TextBox();
            this.txtbPxVenteHT = new System.Windows.Forms.TextBox();
            this.txtbContreInd = new System.Windows.Forms.TextBox();
            this.txtbDosage = new System.Windows.Forms.TextBox();
            this.txtbEffetsTherapeu = new System.Windows.Forms.TextBox();
            this.txtbNumProduit = new System.Windows.Forms.TextBox();
            this.dgvMedicaments = new System.Windows.Forms.DataGridView();
            this.dgvInteractionMedicament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInstruction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDosage = new System.Windows.Forms.Label();
            this.lblContreInd = new System.Windows.Forms.Label();
            this.lblEffetThera = new System.Windows.Forms.Label();
            this.lblNumProduit = new System.Windows.Forms.Label();
            this.lblMedicaments = new System.Windows.Forms.Label();
            this.cbxMedicaments = new System.Windows.Forms.ComboBox();
            this.tabPraticiens = new System.Windows.Forms.TabPage();
            this.dgvPraticiens = new System.Windows.Forms.DataGridView();
            this.dgvCodePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRaisonSociale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdressePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelephonePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNomPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMailPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSpecialitePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClientPraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCoefConfiancePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCoefNotorietePraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbCodePraticien = new System.Windows.Forms.TextBox();
            this.txtbNomPraticien = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblSpecialite = new System.Windows.Forms.Label();
            this.cbxSpecialite = new System.Windows.Forms.ComboBox();
            this.tabVisiteursMedicaux = new System.Windows.Forms.TabPage();
            this.dgvVisiteurMedical = new System.Windows.Forms.DataGridView();
            this.dgvNomVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCodeVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCPVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVilleVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDateNaissanceVisiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtbCodeVisiteur = new System.Windows.Forms.TextBox();
            this.txtbNomVisiteur = new System.Windows.Forms.TextBox();
            this.cmbxSecteurMedical = new System.Windows.Forms.ComboBox();
            this.lblCodeVisiteur = new System.Windows.Forms.Label();
            this.lblNomVisiteur = new System.Windows.Forms.Label();
            this.lblSecteurMedical = new System.Windows.Forms.Label();
            this.btnNewVisiteur = new System.Windows.Forms.Button();
            this.tabApplication.SuspendLayout();
            this.tabMedicament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).BeginInit();
            this.tabPraticiens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).BeginInit();
            this.tabVisiteursMedicaux.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurMedical)).BeginInit();
            this.SuspendLayout();
            // 
            // tabApplication
            // 
            this.tabApplication.Controls.Add(this.tabMedicament);
            this.tabApplication.Controls.Add(this.tabPraticiens);
            this.tabApplication.Controls.Add(this.tabVisiteursMedicaux);
            this.tabApplication.Location = new System.Drawing.Point(0, 0);
            this.tabApplication.Name = "tabApplication";
            this.tabApplication.SelectedIndex = 0;
            this.tabApplication.Size = new System.Drawing.Size(904, 452);
            this.tabApplication.TabIndex = 0;
            // 
            // tabMedicament
            // 
            this.tabMedicament.Controls.Add(this.btnSupprimer);
            this.tabMedicament.Controls.Add(this.btnModifier);
            this.tabMedicament.Controls.Add(this.btnCreer);
            this.tabMedicament.Controls.Add(this.lblPresentation);
            this.tabMedicament.Controls.Add(this.lblPxEchantillon);
            this.tabMedicament.Controls.Add(this.lblPxHT);
            this.tabMedicament.Controls.Add(this.lblFamille);
            this.tabMedicament.Controls.Add(this.txtbPxEchantillon);
            this.tabMedicament.Controls.Add(this.txtbPresentation);
            this.tabMedicament.Controls.Add(this.txtbFamille);
            this.tabMedicament.Controls.Add(this.txtbPxVenteHT);
            this.tabMedicament.Controls.Add(this.txtbContreInd);
            this.tabMedicament.Controls.Add(this.txtbDosage);
            this.tabMedicament.Controls.Add(this.txtbEffetsTherapeu);
            this.tabMedicament.Controls.Add(this.txtbNumProduit);
            this.tabMedicament.Controls.Add(this.dgvMedicaments);
            this.tabMedicament.Controls.Add(this.lblDosage);
            this.tabMedicament.Controls.Add(this.lblContreInd);
            this.tabMedicament.Controls.Add(this.lblEffetThera);
            this.tabMedicament.Controls.Add(this.lblNumProduit);
            this.tabMedicament.Controls.Add(this.lblMedicaments);
            this.tabMedicament.Controls.Add(this.cbxMedicaments);
            this.tabMedicament.Location = new System.Drawing.Point(4, 22);
            this.tabMedicament.Name = "tabMedicament";
            this.tabMedicament.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedicament.Size = new System.Drawing.Size(896, 426);
            this.tabMedicament.TabIndex = 0;
            this.tabMedicament.Text = "Médicaments";
            this.tabMedicament.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(610, 151);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(142, 23);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(610, 112);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(142, 23);
            this.btnModifier.TabIndex = 20;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(610, 73);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(142, 23);
            this.btnCreer.TabIndex = 19;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = true;
            // 
            // lblPresentation
            // 
            this.lblPresentation.AutoSize = true;
            this.lblPresentation.Location = new System.Drawing.Point(586, 20);
            this.lblPresentation.Name = "lblPresentation";
            this.lblPresentation.Size = new System.Drawing.Size(72, 13);
            this.lblPresentation.TabIndex = 18;
            this.lblPresentation.Text = "Présentation :";
            // 
            // lblPxEchantillon
            // 
            this.lblPxEchantillon.AutoSize = true;
            this.lblPxEchantillon.Location = new System.Drawing.Point(309, 138);
            this.lblPxEchantillon.Name = "lblPxEchantillon";
            this.lblPxEchantillon.Size = new System.Drawing.Size(97, 13);
            this.lblPxEchantillon.TabIndex = 17;
            this.lblPxEchantillon.Text = "Prix de l\'échantillon";
            // 
            // lblPxHT
            // 
            this.lblPxHT.AutoSize = true;
            this.lblPxHT.Location = new System.Drawing.Point(309, 99);
            this.lblPxHT.Name = "lblPxHT";
            this.lblPxHT.Size = new System.Drawing.Size(93, 13);
            this.lblPxHT.TabIndex = 16;
            this.lblPxHT.Text = "Prix de vente HT :";
            // 
            // lblFamille
            // 
            this.lblFamille.AutoSize = true;
            this.lblFamille.Location = new System.Drawing.Point(309, 60);
            this.lblFamille.Name = "lblFamille";
            this.lblFamille.Size = new System.Drawing.Size(45, 13);
            this.lblFamille.TabIndex = 15;
            this.lblFamille.Text = "Famille :";
            // 
            // txtbPxEchantillon
            // 
            this.txtbPxEchantillon.Location = new System.Drawing.Point(335, 154);
            this.txtbPxEchantillon.Name = "txtbPxEchantillon";
            this.txtbPxEchantillon.Size = new System.Drawing.Size(171, 20);
            this.txtbPxEchantillon.TabIndex = 14;
            // 
            // txtbPresentation
            // 
            this.txtbPresentation.Location = new System.Drawing.Point(610, 37);
            this.txtbPresentation.Name = "txtbPresentation";
            this.txtbPresentation.Size = new System.Drawing.Size(142, 20);
            this.txtbPresentation.TabIndex = 13;
            // 
            // txtbFamille
            // 
            this.txtbFamille.Location = new System.Drawing.Point(335, 76);
            this.txtbFamille.Name = "txtbFamille";
            this.txtbFamille.Size = new System.Drawing.Size(171, 20);
            this.txtbFamille.TabIndex = 12;
            // 
            // txtbPxVenteHT
            // 
            this.txtbPxVenteHT.Location = new System.Drawing.Point(335, 115);
            this.txtbPxVenteHT.Name = "txtbPxVenteHT";
            this.txtbPxVenteHT.Size = new System.Drawing.Size(171, 20);
            this.txtbPxVenteHT.TabIndex = 11;
            // 
            // txtbContreInd
            // 
            this.txtbContreInd.Location = new System.Drawing.Point(49, 154);
            this.txtbContreInd.Name = "txtbContreInd";
            this.txtbContreInd.Size = new System.Drawing.Size(182, 20);
            this.txtbContreInd.TabIndex = 10;
            // 
            // txtbDosage
            // 
            this.txtbDosage.Location = new System.Drawing.Point(335, 37);
            this.txtbDosage.Name = "txtbDosage";
            this.txtbDosage.Size = new System.Drawing.Size(171, 20);
            this.txtbDosage.TabIndex = 9;
            // 
            // txtbEffetsTherapeu
            // 
            this.txtbEffetsTherapeu.Location = new System.Drawing.Point(49, 115);
            this.txtbEffetsTherapeu.Name = "txtbEffetsTherapeu";
            this.txtbEffetsTherapeu.Size = new System.Drawing.Size(182, 20);
            this.txtbEffetsTherapeu.TabIndex = 8;
            // 
            // txtbNumProduit
            // 
            this.txtbNumProduit.Location = new System.Drawing.Point(49, 76);
            this.txtbNumProduit.Name = "txtbNumProduit";
            this.txtbNumProduit.Size = new System.Drawing.Size(182, 20);
            this.txtbNumProduit.TabIndex = 7;
            // 
            // dgvMedicaments
            // 
            this.dgvMedicaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInteractionMedicament,
            this.dgvInstruction});
            this.dgvMedicaments.Location = new System.Drawing.Point(8, 212);
            this.dgvMedicaments.Name = "dgvMedicaments";
            this.dgvMedicaments.Size = new System.Drawing.Size(879, 204);
            this.dgvMedicaments.TabIndex = 6;
            // 
            // dgvInteractionMedicament
            // 
            this.dgvInteractionMedicament.HeaderText = "Interactions avec les autres médicaments";
            this.dgvInteractionMedicament.Name = "dgvInteractionMedicament";
            // 
            // dgvInstruction
            // 
            this.dgvInstruction.HeaderText = "Instructions";
            this.dgvInstruction.Name = "dgvInstruction";
            // 
            // lblDosage
            // 
            this.lblDosage.AutoSize = true;
            this.lblDosage.Location = new System.Drawing.Point(309, 20);
            this.lblDosage.Name = "lblDosage";
            this.lblDosage.Size = new System.Drawing.Size(50, 13);
            this.lblDosage.TabIndex = 5;
            this.lblDosage.Text = "Dosage :";
            // 
            // lblContreInd
            // 
            this.lblContreInd.AutoSize = true;
            this.lblContreInd.Location = new System.Drawing.Point(17, 138);
            this.lblContreInd.Name = "lblContreInd";
            this.lblContreInd.Size = new System.Drawing.Size(97, 13);
            this.lblContreInd.TabIndex = 4;
            this.lblContreInd.Text = "Contre-indications :";
            // 
            // lblEffetThera
            // 
            this.lblEffetThera.AutoSize = true;
            this.lblEffetThera.Location = new System.Drawing.Point(17, 99);
            this.lblEffetThera.Name = "lblEffetThera";
            this.lblEffetThera.Size = new System.Drawing.Size(116, 13);
            this.lblEffetThera.TabIndex = 3;
            this.lblEffetThera.Text = "EFfets thérapeutiques :";
            // 
            // lblNumProduit
            // 
            this.lblNumProduit.AutoSize = true;
            this.lblNumProduit.Location = new System.Drawing.Point(17, 60);
            this.lblNumProduit.Name = "lblNumProduit";
            this.lblNumProduit.Size = new System.Drawing.Size(85, 13);
            this.lblNumProduit.TabIndex = 2;
            this.lblNumProduit.Text = "Numéro produit :";
            // 
            // lblMedicaments
            // 
            this.lblMedicaments.AutoSize = true;
            this.lblMedicaments.Location = new System.Drawing.Point(17, 20);
            this.lblMedicaments.Name = "lblMedicaments";
            this.lblMedicaments.Size = new System.Drawing.Size(76, 13);
            this.lblMedicaments.TabIndex = 1;
            this.lblMedicaments.Text = "Médicaments :";
            // 
            // cbxMedicaments
            // 
            this.cbxMedicaments.FormattingEnabled = true;
            this.cbxMedicaments.Location = new System.Drawing.Point(49, 36);
            this.cbxMedicaments.Name = "cbxMedicaments";
            this.cbxMedicaments.Size = new System.Drawing.Size(182, 21);
            this.cbxMedicaments.TabIndex = 0;
            // 
            // tabPraticiens
            // 
            this.tabPraticiens.Controls.Add(this.dgvPraticiens);
            this.tabPraticiens.Controls.Add(this.txtbCodePraticien);
            this.tabPraticiens.Controls.Add(this.txtbNomPraticien);
            this.tabPraticiens.Controls.Add(this.lblCode);
            this.tabPraticiens.Controls.Add(this.lblNom);
            this.tabPraticiens.Controls.Add(this.lblSpecialite);
            this.tabPraticiens.Controls.Add(this.cbxSpecialite);
            this.tabPraticiens.Location = new System.Drawing.Point(4, 22);
            this.tabPraticiens.Name = "tabPraticiens";
            this.tabPraticiens.Padding = new System.Windows.Forms.Padding(3);
            this.tabPraticiens.Size = new System.Drawing.Size(896, 426);
            this.tabPraticiens.TabIndex = 1;
            this.tabPraticiens.Text = "Praticiens";
            this.tabPraticiens.UseVisualStyleBackColor = true;
            // 
            // dgvPraticiens
            // 
            this.dgvPraticiens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPraticiens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPraticiens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCodePraticien,
            this.dgvRaisonSociale,
            this.dgvAdressePraticien,
            this.dgvTelephonePraticien,
            this.dgvNomPraticien,
            this.dgvMailPraticien,
            this.dgvSpecialitePraticien,
            this.dgvClientPraticien,
            this.dgvCoefConfiancePraticien,
            this.dgvCoefNotorietePraticien});
            this.dgvPraticiens.Location = new System.Drawing.Point(8, 158);
            this.dgvPraticiens.Name = "dgvPraticiens";
            this.dgvPraticiens.Size = new System.Drawing.Size(879, 258);
            this.dgvPraticiens.TabIndex = 6;
            // 
            // dgvCodePraticien
            // 
            this.dgvCodePraticien.HeaderText = "Code";
            this.dgvCodePraticien.Name = "dgvCodePraticien";
            // 
            // dgvRaisonSociale
            // 
            this.dgvRaisonSociale.HeaderText = "Raison social";
            this.dgvRaisonSociale.Name = "dgvRaisonSociale";
            // 
            // dgvAdressePraticien
            // 
            this.dgvAdressePraticien.HeaderText = "Adresse";
            this.dgvAdressePraticien.Name = "dgvAdressePraticien";
            // 
            // dgvTelephonePraticien
            // 
            this.dgvTelephonePraticien.HeaderText = "Téléphone";
            this.dgvTelephonePraticien.Name = "dgvTelephonePraticien";
            // 
            // dgvNomPraticien
            // 
            this.dgvNomPraticien.HeaderText = "Nom";
            this.dgvNomPraticien.Name = "dgvNomPraticien";
            // 
            // dgvMailPraticien
            // 
            this.dgvMailPraticien.HeaderText = "Mail";
            this.dgvMailPraticien.Name = "dgvMailPraticien";
            // 
            // dgvSpecialitePraticien
            // 
            this.dgvSpecialitePraticien.HeaderText = "Specialite";
            this.dgvSpecialitePraticien.Name = "dgvSpecialitePraticien";
            // 
            // dgvClientPraticien
            // 
            this.dgvClientPraticien.HeaderText = "Client";
            this.dgvClientPraticien.Name = "dgvClientPraticien";
            // 
            // dgvCoefConfiancePraticien
            // 
            this.dgvCoefConfiancePraticien.HeaderText = "Coef. Confiance";
            this.dgvCoefConfiancePraticien.Name = "dgvCoefConfiancePraticien";
            // 
            // dgvCoefNotorietePraticien
            // 
            this.dgvCoefNotorietePraticien.HeaderText = "Coef. Notoriete";
            this.dgvCoefNotorietePraticien.Name = "dgvCoefNotorietePraticien";
            // 
            // txtbCodePraticien
            // 
            this.txtbCodePraticien.Location = new System.Drawing.Point(467, 92);
            this.txtbCodePraticien.Name = "txtbCodePraticien";
            this.txtbCodePraticien.Size = new System.Drawing.Size(161, 20);
            this.txtbCodePraticien.TabIndex = 5;
            // 
            // txtbNomPraticien
            // 
            this.txtbNomPraticien.Location = new System.Drawing.Point(467, 44);
            this.txtbNomPraticien.Name = "txtbNomPraticien";
            this.txtbNomPraticien.Size = new System.Drawing.Size(161, 20);
            this.txtbNomPraticien.TabIndex = 4;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(442, 76);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(38, 13);
            this.lblCode.TabIndex = 3;
            this.lblCode.Text = "Code :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(442, 28);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(35, 13);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom :";
            // 
            // lblSpecialite
            // 
            this.lblSpecialite.AutoSize = true;
            this.lblSpecialite.Location = new System.Drawing.Point(142, 52);
            this.lblSpecialite.Name = "lblSpecialite";
            this.lblSpecialite.Size = new System.Drawing.Size(59, 13);
            this.lblSpecialite.TabIndex = 1;
            this.lblSpecialite.Text = "Spécialité :";
            // 
            // cbxSpecialite
            // 
            this.cbxSpecialite.FormattingEnabled = true;
            this.cbxSpecialite.Location = new System.Drawing.Point(173, 68);
            this.cbxSpecialite.Name = "cbxSpecialite";
            this.cbxSpecialite.Size = new System.Drawing.Size(176, 21);
            this.cbxSpecialite.TabIndex = 0;
            // 
            // tabVisiteursMedicaux
            // 
            this.tabVisiteursMedicaux.Controls.Add(this.btnNewVisiteur);
            this.tabVisiteursMedicaux.Controls.Add(this.dgvVisiteurMedical);
            this.tabVisiteursMedicaux.Controls.Add(this.txtbCodeVisiteur);
            this.tabVisiteursMedicaux.Controls.Add(this.txtbNomVisiteur);
            this.tabVisiteursMedicaux.Controls.Add(this.cmbxSecteurMedical);
            this.tabVisiteursMedicaux.Controls.Add(this.lblCodeVisiteur);
            this.tabVisiteursMedicaux.Controls.Add(this.lblNomVisiteur);
            this.tabVisiteursMedicaux.Controls.Add(this.lblSecteurMedical);
            this.tabVisiteursMedicaux.Location = new System.Drawing.Point(4, 22);
            this.tabVisiteursMedicaux.Name = "tabVisiteursMedicaux";
            this.tabVisiteursMedicaux.Padding = new System.Windows.Forms.Padding(3);
            this.tabVisiteursMedicaux.Size = new System.Drawing.Size(896, 426);
            this.tabVisiteursMedicaux.TabIndex = 2;
            this.tabVisiteursMedicaux.Text = "Visiteurs médicaux";
            this.tabVisiteursMedicaux.UseVisualStyleBackColor = true;
            // 
            // dgvVisiteurMedical
            // 
            this.dgvVisiteurMedical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisiteurMedical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisiteurMedical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNomVisiteur,
            this.dgvCodeVisiteur,
            this.dgvCPVisiteur,
            this.dgvVilleVisiteur,
            this.dgvDateNaissanceVisiteur});
            this.dgvVisiteurMedical.Location = new System.Drawing.Point(8, 164);
            this.dgvVisiteurMedical.Name = "dgvVisiteurMedical";
            this.dgvVisiteurMedical.Size = new System.Drawing.Size(882, 252);
            this.dgvVisiteurMedical.TabIndex = 6;
            // 
            // dgvNomVisiteur
            // 
            this.dgvNomVisiteur.HeaderText = "Nom";
            this.dgvNomVisiteur.Name = "dgvNomVisiteur";
            // 
            // dgvCodeVisiteur
            // 
            this.dgvCodeVisiteur.HeaderText = "Code";
            this.dgvCodeVisiteur.Name = "dgvCodeVisiteur";
            // 
            // dgvCPVisiteur
            // 
            this.dgvCPVisiteur.HeaderText = "Code postal";
            this.dgvCPVisiteur.Name = "dgvCPVisiteur";
            // 
            // dgvVilleVisiteur
            // 
            this.dgvVilleVisiteur.HeaderText = "Ville";
            this.dgvVilleVisiteur.Name = "dgvVilleVisiteur";
            // 
            // dgvDateNaissanceVisiteur
            // 
            this.dgvDateNaissanceVisiteur.HeaderText = "Date naissance";
            this.dgvDateNaissanceVisiteur.Name = "dgvDateNaissanceVisiteur";
            // 
            // txtbCodeVisiteur
            // 
            this.txtbCodeVisiteur.Location = new System.Drawing.Point(494, 95);
            this.txtbCodeVisiteur.Name = "txtbCodeVisiteur";
            this.txtbCodeVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtbCodeVisiteur.TabIndex = 5;
            // 
            // txtbNomVisiteur
            // 
            this.txtbNomVisiteur.Location = new System.Drawing.Point(494, 47);
            this.txtbNomVisiteur.Name = "txtbNomVisiteur";
            this.txtbNomVisiteur.Size = new System.Drawing.Size(100, 20);
            this.txtbNomVisiteur.TabIndex = 4;
            // 
            // cmbxSecteurMedical
            // 
            this.cmbxSecteurMedical.FormattingEnabled = true;
            this.cmbxSecteurMedical.Location = new System.Drawing.Point(179, 94);
            this.cmbxSecteurMedical.Name = "cmbxSecteurMedical";
            this.cmbxSecteurMedical.Size = new System.Drawing.Size(175, 21);
            this.cmbxSecteurMedical.TabIndex = 3;
            // 
            // lblCodeVisiteur
            // 
            this.lblCodeVisiteur.AutoSize = true;
            this.lblCodeVisiteur.Location = new System.Drawing.Point(478, 78);
            this.lblCodeVisiteur.Name = "lblCodeVisiteur";
            this.lblCodeVisiteur.Size = new System.Drawing.Size(38, 13);
            this.lblCodeVisiteur.TabIndex = 2;
            this.lblCodeVisiteur.Text = "Code :";
            // 
            // lblNomVisiteur
            // 
            this.lblNomVisiteur.AutoSize = true;
            this.lblNomVisiteur.Location = new System.Drawing.Point(478, 31);
            this.lblNomVisiteur.Name = "lblNomVisiteur";
            this.lblNomVisiteur.Size = new System.Drawing.Size(35, 13);
            this.lblNomVisiteur.TabIndex = 1;
            this.lblNomVisiteur.Text = "Nom :";
            // 
            // lblSecteurMedical
            // 
            this.lblSecteurMedical.AutoSize = true;
            this.lblSecteurMedical.Location = new System.Drawing.Point(130, 78);
            this.lblSecteurMedical.Name = "lblSecteurMedical";
            this.lblSecteurMedical.Size = new System.Drawing.Size(89, 13);
            this.lblSecteurMedical.TabIndex = 0;
            this.lblSecteurMedical.Text = "Secteur médical :";
            // 
            // btnNewVisiteur
            // 
            this.btnNewVisiteur.Location = new System.Drawing.Point(680, 38);
            this.btnNewVisiteur.Name = "btnNewVisiteur";
            this.btnNewVisiteur.Size = new System.Drawing.Size(120, 36);
            this.btnNewVisiteur.TabIndex = 7;
            this.btnNewVisiteur.Text = "Nouveau";
            this.btnNewVisiteur.UseVisualStyleBackColor = true;
            // 
            // frm_Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.tabApplication);
            this.Name = "frm_Application";
            this.Text = "Application GSB";
            this.tabApplication.ResumeLayout(false);
            this.tabMedicament.ResumeLayout(false);
            this.tabMedicament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicaments)).EndInit();
            this.tabPraticiens.ResumeLayout(false);
            this.tabPraticiens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPraticiens)).EndInit();
            this.tabVisiteursMedicaux.ResumeLayout(false);
            this.tabVisiteursMedicaux.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisiteurMedical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabApplication;
        private System.Windows.Forms.TabPage tabMedicament;
        private System.Windows.Forms.DataGridView dgvMedicaments;
        private System.Windows.Forms.Label lblDosage;
        private System.Windows.Forms.Label lblContreInd;
        private System.Windows.Forms.Label lblEffetThera;
        private System.Windows.Forms.Label lblNumProduit;
        private System.Windows.Forms.Label lblMedicaments;
        private System.Windows.Forms.ComboBox cbxMedicaments;
        private System.Windows.Forms.TabPage tabPraticiens;
        private System.Windows.Forms.TabPage tabVisiteursMedicaux;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Label lblPresentation;
        private System.Windows.Forms.Label lblPxEchantillon;
        private System.Windows.Forms.Label lblPxHT;
        private System.Windows.Forms.Label lblFamille;
        private System.Windows.Forms.TextBox txtbPxEchantillon;
        private System.Windows.Forms.TextBox txtbPresentation;
        private System.Windows.Forms.TextBox txtbFamille;
        private System.Windows.Forms.TextBox txtbPxVenteHT;
        private System.Windows.Forms.TextBox txtbContreInd;
        private System.Windows.Forms.TextBox txtbDosage;
        private System.Windows.Forms.TextBox txtbEffetsTherapeu;
        private System.Windows.Forms.TextBox txtbNumProduit;
        private System.Windows.Forms.TextBox txtbCodePraticien;
        private System.Windows.Forms.TextBox txtbNomPraticien;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblSpecialite;
        private System.Windows.Forms.ComboBox cbxSpecialite;
        private System.Windows.Forms.DataGridView dgvPraticiens;
        private System.Windows.Forms.DataGridView dgvVisiteurMedical;
        private System.Windows.Forms.TextBox txtbCodeVisiteur;
        private System.Windows.Forms.TextBox txtbNomVisiteur;
        private System.Windows.Forms.ComboBox cmbxSecteurMedical;
        private System.Windows.Forms.Label lblCodeVisiteur;
        private System.Windows.Forms.Label lblNomVisiteur;
        private System.Windows.Forms.Label lblSecteurMedical;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRaisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAdressePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTelephonePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMailPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSpecialitePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClientPraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCoefConfiancePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCoefNotorietePraticien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNomVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCodeVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCPVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVilleVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDateNaissanceVisiteur;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInteractionMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInstruction;
        private System.Windows.Forms.Button btnNewVisiteur;
    }
}