namespace TholdiApplication
{
    partial class FormPageConnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageConnexion));
            this.boutonConnexion = new System.Windows.Forms.Button();
            this.textBoxNomUtilisateur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMotDePasse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aIDEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manuelUtilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mENUPRINCIPALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_Show_Hide = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boutonConnexion
            // 
            this.boutonConnexion.BackColor = System.Drawing.Color.RoyalBlue;
            this.boutonConnexion.Font = new System.Drawing.Font("Tahoma", 8F);
            this.boutonConnexion.ForeColor = System.Drawing.Color.White;
            this.boutonConnexion.Location = new System.Drawing.Point(359, 504);
            this.boutonConnexion.Name = "boutonConnexion";
            this.boutonConnexion.Size = new System.Drawing.Size(273, 40);
            this.boutonConnexion.TabIndex = 0;
            this.boutonConnexion.Text = "Connexion";
            this.boutonConnexion.UseVisualStyleBackColor = false;
            this.boutonConnexion.Click += new System.EventHandler(this.boutonConnexion_Click);
            // 
            // textBoxNomUtilisateur
            // 
            this.textBoxNomUtilisateur.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxNomUtilisateur.Location = new System.Drawing.Point(359, 439);
            this.textBoxNomUtilisateur.Name = "textBoxNomUtilisateur";
            this.textBoxNomUtilisateur.Size = new System.Drawing.Size(273, 20);
            this.textBoxNomUtilisateur.TabIndex = 1;
            this.textBoxNomUtilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNomUtilisateur.Click += new System.EventHandler(this.textBoxNomUtilisateur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(470, 423);
            this.label1.MaximumSize = new System.Drawing.Size(120, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Identifiant";
            // 
            // textBoxMotDePasse
            // 
            this.textBoxMotDePasse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxMotDePasse.Location = new System.Drawing.Point(359, 478);
            this.textBoxMotDePasse.Name = "textBoxMotDePasse";
            this.textBoxMotDePasse.Size = new System.Drawing.Size(273, 20);
            this.textBoxMotDePasse.TabIndex = 3;
            this.textBoxMotDePasse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMotDePasse.Click += new System.EventHandler(this.textBoxMotDePasse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.Location = new System.Drawing.Point(470, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de passe";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aIDEToolStripMenuItem,
            this.mENUPRINCIPALToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aIDEToolStripMenuItem
            // 
            this.aIDEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aIDEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manuelUtilisateurToolStripMenuItem});
            this.aIDEToolStripMenuItem.Name = "aIDEToolStripMenuItem";
            this.aIDEToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aIDEToolStripMenuItem.Text = "AIDE";
            // 
            // manuelUtilisateurToolStripMenuItem
            // 
            this.manuelUtilisateurToolStripMenuItem.Name = "manuelUtilisateurToolStripMenuItem";
            this.manuelUtilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manuelUtilisateurToolStripMenuItem.Text = "Manuel utilisateur";            
            // 
            // mENUPRINCIPALToolStripMenuItem
            // 
            this.mENUPRINCIPALToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mENUPRINCIPALToolStripMenuItem.Name = "mENUPRINCIPALToolStripMenuItem";
            this.mENUPRINCIPALToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.mENUPRINCIPALToolStripMenuItem.Text = "MENU PRINCIPAL";
            this.mENUPRINCIPALToolStripMenuItem.Click += new System.EventHandler(this.mENUPRINCIPALToolStripMenuItem_Click);
            // 
            // checkBox_Show_Hide
            // 
            this.checkBox_Show_Hide.AutoSize = true;
            this.checkBox_Show_Hide.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_Show_Hide.Location = new System.Drawing.Point(651, 478);
            this.checkBox_Show_Hide.Name = "checkBox_Show_Hide";
            this.checkBox_Show_Hide.Size = new System.Drawing.Size(108, 17);
            this.checkBox_Show_Hide.TabIndex = 7;
            this.checkBox_Show_Hide.Text = "Afficher/Masquer";
            this.checkBox_Show_Hide.UseVisualStyleBackColor = false;
            this.checkBox_Show_Hide.CheckedChanged += new System.EventHandler(this.checkBox_Show_Hide_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::TholdiApplication.Properties.Resources.carton;
            this.pictureBox1.Location = new System.Drawing.Point(108, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 381);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::TholdiApplication.Properties.Resources.logo_blue;
            this.pictureBox2.Location = new System.Drawing.Point(753, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(753, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Bienvenue sur l\'application";
            // 
            // FormPageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(912, 571);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox_Show_Hide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMotDePasse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomUtilisateur);
            this.Controls.Add(this.boutonConnexion);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPageConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tholdi - Connexion";
            this.Load += new System.EventHandler(this.FormPageConnexion_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boutonConnexion;
        private System.Windows.Forms.TextBox textBoxNomUtilisateur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMotDePasse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUPRINCIPALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIDEToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_Show_Hide;
        private System.Windows.Forms.ToolStripMenuItem manuelUtilisateurToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
    }
}