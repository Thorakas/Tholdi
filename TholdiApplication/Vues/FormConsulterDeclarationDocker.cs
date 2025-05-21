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
    public partial class FormConsulterDeclarationDocker : Form
    {
        public FormConsulterDeclarationDocker()
        {
            InitializeComponent();
        }

       // A l'ouverture du formulaire, affiche toutes les déclarations faites
        private void FormConsulterDeclarationDocker_Load_1(object sender, EventArgs e)
        {
            List<Declaration> collectionDeclaration = Declaration.FetchAll();
            dataGridView1.DataSource = collectionDeclaration;
        }
        
        //Retourne vers la page principal des dockers
        private void rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalDocker()));
            t.Start();
            this.Close();
        }

        //Retourne à la page d'accueil du logiciel
        private void mENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
