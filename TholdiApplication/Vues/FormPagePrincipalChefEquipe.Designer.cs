namespace TholdiApplication.Vues
{
    partial class FormPagePrincipalChefEquipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagePrincipalChefEquipe));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBienvenueChefEquipe = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirUneInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterUneInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prévoirUneInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RetournerVersLeMenuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::TholdiApplication.Properties.Resources.logo_blue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(494, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelBienvenueChefEquipe
            // 
            this.labelBienvenueChefEquipe.AutoSize = true;
            this.labelBienvenueChefEquipe.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenueChefEquipe.Location = new System.Drawing.Point(227, 228);
            this.labelBienvenueChefEquipe.Name = "labelBienvenueChefEquipe";
            this.labelBienvenueChefEquipe.Size = new System.Drawing.Size(268, 13);
            this.labelBienvenueChefEquipe.TabIndex = 3;
            this.labelBienvenueChefEquipe.Text = "Bienvenue sur l\'interface destinées aux Chefs d\'Equipe.";
            this.labelBienvenueChefEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(485, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interface des Chefs d\'Equipe";
            // 
            // inspectionToolStripMenuItem
            // 
            this.inspectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saisirUneInspectionToolStripMenuItem,
            this.consulterUneInspectionToolStripMenuItem});
            this.inspectionToolStripMenuItem.Name = "inspectionToolStripMenuItem";
            this.inspectionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.inspectionToolStripMenuItem.Text = "INSPECTION";
            // 
            // saisirUneInspectionToolStripMenuItem
            // 
            this.saisirUneInspectionToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.saisirUneInspectionToolStripMenuItem.Name = "saisirUneInspectionToolStripMenuItem";
            this.saisirUneInspectionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.saisirUneInspectionToolStripMenuItem.Text = "Saisir une inspection";
            this.saisirUneInspectionToolStripMenuItem.Click += new System.EventHandler(this.saisirUneInspectionToolStripMenuItem_Click);
            // 
            // consulterUneInspectionToolStripMenuItem
            // 
            this.consulterUneInspectionToolStripMenuItem.Name = "consulterUneInspectionToolStripMenuItem";
            this.consulterUneInspectionToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.consulterUneInspectionToolStripMenuItem.Text = "Consulter une inspection";
            this.consulterUneInspectionToolStripMenuItem.Click += new System.EventHandler(this.consulterUneInspectionToolStripMenuItem_Click);
            // 
            // problèmeToolStripMenuItem
            // 
            this.problèmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prévoirUneInspectionToolStripMenuItem});
            this.problèmeToolStripMenuItem.Name = "problèmeToolStripMenuItem";
            this.problèmeToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.problèmeToolStripMenuItem.Text = "PROBLEME";
            // 
            // prévoirUneInspectionToolStripMenuItem
            // 
            this.prévoirUneInspectionToolStripMenuItem.Name = "prévoirUneInspectionToolStripMenuItem";
            this.prévoirUneInspectionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.prévoirUneInspectionToolStripMenuItem.Text = "Consulter les problèmes";
            this.prévoirUneInspectionToolStripMenuItem.Click += new System.EventHandler(this.prévoirUneInspectionToolStripMenuItem_Click);
            // 
            // RetournerVersLeMenuPrincipalToolStripMenuItem
            // 
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Name = "RetournerVersLeMenuPrincipalToolStripMenuItem";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(225, 20);
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Text = "RETOURNER VERS LE MENU PRINCIPAL";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.RetournerVersLeMenuPrincipalToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inspectionToolStripMenuItem,
            this.problèmeToolStripMenuItem,
            this.RetournerVersLeMenuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FormPagePrincipalChefEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBienvenueChefEquipe);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPagePrincipalChefEquipe";
            this.Text = "Tholdi - Interface (Chef d\'Equipe)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBienvenueChefEquipe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem inspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirUneInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterUneInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prévoirUneInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetournerVersLeMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}