namespace TholdiApplication.Vues
{
    partial class FormConsulterDeclaration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulterDeclaration));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Teal;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem,
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rETOURVERSLEMENUPRINCIPALToolStripMenuItem
            // 
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem.Name = "rETOURVERSLEMENUPRINCIPALToolStripMenuItem";
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem.Text = "MENU PRINCIPAL";
            this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem.Click += new System.EventHandler(this.rETOURVERSLEMENUPRINCIPALToolStripMenuItem_Click);
            // 
            // rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem
            // 
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem.Name = "rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem";
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem.Size = new System.Drawing.Size(241, 20);
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem.Text = "RETOUR VERS L\'INTERFACE DES DOCKERS";
            this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem.Click += new System.EventHandler(this.rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(840, 288);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(725, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consulter les déclarations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::TholdiApplication.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FormConsulterDeclaration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TholdiApplication.Properties.Resources.IHMBGRD;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 571);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConsulterDeclaration";
            this.Text = "Tholdi - Consulter les déclarations";
            this.Load += new System.EventHandler(this.FormConsulterDeclaration_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rETOURVERSLEMENUPRINCIPALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}