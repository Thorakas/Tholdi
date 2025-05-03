namespace TholdiApplication.Vues
{
    partial class FormPagePrincipalDocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagePrincipalDocker));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelBienvenueDockers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterUneInspectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.problèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saisirUnProblèmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pictureBox1.Location = new System.Drawing.Point(495, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelBienvenueDockers
            // 
            this.labelBienvenueDockers.AutoSize = true;
            this.labelBienvenueDockers.BackColor = System.Drawing.Color.Transparent;
            this.labelBienvenueDockers.Location = new System.Drawing.Point(204, 220);
            this.labelBienvenueDockers.Name = "labelBienvenueDockers";
            this.labelBienvenueDockers.Size = new System.Drawing.Size(269, 13);
            this.labelBienvenueDockers.TabIndex = 2;
            this.labelBienvenueDockers.Text = "Bienvenue sur l\'interface Tholdi destinées aux Dockers.";
            this.labelBienvenueDockers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(516, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interface des Dockers";
            // 
            // inspectionToolStripMenuItem
            // 
            this.inspectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterUneInspectionToolStripMenuItem});
            this.inspectionToolStripMenuItem.Name = "inspectionToolStripMenuItem";
            this.inspectionToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.inspectionToolStripMenuItem.Text = "INSPECTION";
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
            this.saisirUnProblèmeToolStripMenuItem});
            this.problèmeToolStripMenuItem.Name = "problèmeToolStripMenuItem";
            this.problèmeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.problèmeToolStripMenuItem.Text = "DECLARATION";
            // 
            // saisirUnProblèmeToolStripMenuItem
            // 
            this.saisirUnProblèmeToolStripMenuItem.Name = "saisirUnProblèmeToolStripMenuItem";
            this.saisirUnProblèmeToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.saisirUnProblèmeToolStripMenuItem.Text = "Saisir une déclaration ";
            this.saisirUnProblèmeToolStripMenuItem.Click += new System.EventHandler(this.saisirUnProblèmeToolStripMenuItem_Click);
            // 
            // RetournerVersLeMenuPrincipalToolStripMenuItem
            // 
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Name = "RetournerVersLeMenuPrincipalToolStripMenuItem";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(227, 20);
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Text = "RETOURNER VERS LE MENU PRINCIPAL";
            this.RetournerVersLeMenuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.rETOURNERVERSLEMENUPRINCIPALToolStripMenuItem_Click);
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
            // FormPagePrincipalDocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelBienvenueDockers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormPagePrincipalDocker";
            this.Text = "Tholdi - Interface (Docker)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelBienvenueDockers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem inspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterUneInspectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem problèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saisirUnProblèmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RetournerVersLeMenuPrincipalToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}