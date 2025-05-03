namespace TholdiApplication.Vues
{
    partial class FormConsulterProbleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulterProbleme));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::TholdiApplication.Properties.Resources.logo_blue;
            this.pictureBox2.Location = new System.Drawing.Point(12, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(843, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(743, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulter un problème";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 160);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(843, 290);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Consulter un problème";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem,
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "MenuPrincipal";
            // 
            // rETOURNERPAGEPRINCIPALEToolStripMenuItem
            // 
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem.Name = "rETOURNERPAGEPRINCIPALEToolStripMenuItem";
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem.Text = "MENU PRINCIPAL";
            this.rETOURNERPAGEPRINCIPALEToolStripMenuItem.Click += new System.EventHandler(this.rETOURNERPAGEPRINCIPALEToolStripMenuItem_Click);
            // 
            // rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem
            // 
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem.Name = "rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem";
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem.Size = new System.Drawing.Size(225, 20);
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem.Text = "RETOUR VERS L\'INTERFACE DES CHEFS";
            this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem.Click += new System.EventHandler(this.rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem_Click);
            // 
            // FormConsulterProbleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHM2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 571);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormConsulterProbleme";
            this.Text = "THOLDI - Consulter un problème";
            this.Load += new System.EventHandler(this.FormConsulterProbleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rETOURNERPAGEPRINCIPALEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem;
    }
}