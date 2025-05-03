using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TholdiApplication.Modeles;
using TholdiApplication.Vues;


namespace TholdiApplication.Vues
{
    public partial class FormPagePrincipalDocker : Form
    {
        public FormPagePrincipalDocker()
        {
            InitializeComponent();
        }

        private void saisirUnProblèmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormSaisirDeclarationDocker()));
            t.Start();
            this.Close();
        }

        private void rETOURNERVERSLEMENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous retourner au menu principal THOLDI ?", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
                t.Start();
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormSaisirDeclarationDocker()));
            t.Start();
            this.Close();
        }

        private void consulterUneInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormConsulterInspectionDocker()));
            t.Start();
            this.Close();
        }

    }
}
