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
    public partial class FormConsulterProbleme : Form
    {
        public FormConsulterProbleme()
        {
            InitializeComponent();
        }

        // A l'ouverture du formulaire, affiche toutes la liste des problèmes existants
        private void FormConsulterProbleme_Load(object sender, EventArgs e)
        {
            List<Probleme> collectionProblemee = Probleme.FetchAll();
            listBox1.DataSource = collectionProblemee;
            listBox1.ValueMember = "LIBELLEPROBLEME";
        }

        //Retourne à la page d'accueil du logiciel
        private void rETOURNERPAGEPRINCIPALEToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Retourne vers la page principal des chefs d'équipe
        private void rETOURVERSLINTERFACEDESCHEFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalChefEquipe()));
            t.Start();
            this.Close();
        }
    }
}
