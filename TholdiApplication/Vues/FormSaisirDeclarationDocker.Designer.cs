namespace TholdiApplication.Vues
{
    partial class FormSaisirDeclarationDocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaisirDeclarationDocker));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.boutonTransfertDonnees = new System.Windows.Forms.Button();
            this.textBoxMotif = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.RetournerVersLeMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.boutonTransfertDonnees);
            this.groupBox1.Controls.Add(this.textBoxMotif);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(17, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 273);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Effectuer la saisie d\'une déclaration";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Visite annuelle",
            "Probleme",
            "Recyclage",
            "Autre"});
            this.comboBox2.Location = new System.Drawing.Point(169, 103);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(289, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(168, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(290, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(169, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(182, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Si oui, veuillez cocher cette case";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Urgence";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(169, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(290, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // boutonTransfertDonnees
            // 
            this.boutonTransfertDonnees.BackColor = System.Drawing.Color.RoyalBlue;
            this.boutonTransfertDonnees.ForeColor = System.Drawing.Color.White;
            this.boutonTransfertDonnees.Location = new System.Drawing.Point(178, 224);
            this.boutonTransfertDonnees.Name = "boutonTransfertDonnees";
            this.boutonTransfertDonnees.Size = new System.Drawing.Size(290, 43);
            this.boutonTransfertDonnees.TabIndex = 15;
            this.boutonTransfertDonnees.Text = "Valider la déclaration";
            this.boutonTransfertDonnees.UseVisualStyleBackColor = false;
            this.boutonTransfertDonnees.Click += new System.EventHandler(this.boutonTransfertDonnees_Click);
            // 
            // textBoxMotif
            // 
            this.textBoxMotif.Location = new System.Drawing.Point(169, 139);
            this.textBoxMotif.Name = "textBoxMotif";
            this.textBoxMotif.Size = new System.Drawing.Size(290, 20);
            this.textBoxMotif.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Date de déclaration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Commentaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Libellé du problème";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numéro du container";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label2.Location = new System.Drawing.Point(396, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisir une déclaration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::TholdiApplication.Properties.Resources.logo_blue;
            this.pictureBox1.Location = new System.Drawing.Point(102, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RetournerVersLeMenuPrincipalToolStripMenuItem,
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // RetournerVersLeMenuPrincipalToolStripMenuItem
            // 
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Name = "RetournerVersLeMenuPrincipalToolStripMenuItem";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Text = "MENU PRINCIPAL";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.RetournerVersLeMenuPrincipalToolStripMenuItem_Click);
            // 
            // rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem
            // 
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem.Name = "rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem";
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem.Size = new System.Drawing.Size(263, 20);
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem.Text = "RETOURNER VERS L\'INTERFACE DES DOCKERS";
            this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem.Click += new System.EventHandler(this.rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click);
            // 
            // FormSaisirDeclarationDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormSaisirDeclarationDocker";
            this.Text = "Tholdi - Saisir une déclaration (Docker)";
            this.Load += new System.EventHandler(this.FormSaisirDeclarationDocker_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button boutonTransfertDonnees;
        private System.Windows.Forms.TextBox textBoxMotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem RetournerVersLeMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolStripMenuItem rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem;
    }
}