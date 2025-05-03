using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TholdiApplication.Modeles;
using TholdiApplication.Vues;
using System.Threading;

namespace TholdiApplication.Vues
{
    public partial class FormConsulterInspectionDocker : Form
    {
        public FormConsulterInspectionDocker()
        {
            InitializeComponent();
        }

        private void FormConsulterInspectionDocker_Load(object sender, EventArgs e)
        {
            List<Inspection> collectionInspectionPrevue = Inspection.FetchAllPrevue();
            dataGridView1.DataSource = collectionInspectionPrevue;
        }

        private void rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalDocker()));
            t.Start();
            this.Close();
        }

        private void RetournerVersLeMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous retourner au menu principal THOLDI ? Vous serez déconnecté", "Avertissement", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
    }
}
