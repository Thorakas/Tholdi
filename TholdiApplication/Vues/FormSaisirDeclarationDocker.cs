using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TholdiApplication.Vues;
using TholdiApplication.Modeles;
using System.Threading;

namespace TholdiApplication.Vues
{
    public partial class FormSaisirDeclarationDocker : Form
    {
        public FormSaisirDeclarationDocker()
        {
            InitializeComponent();
        }

        // Bouton qui envoie les données inséré dans le formulaire pour déclarer un problème de container
        private void boutonTransfertDonnees_Click(object sender, EventArgs e)
        {
            Declaration uneDeclaration = new Declaration();
            long numContain;
            string libelleProb;
            string coment;
            DateTime dateDecla;
            bool urgent;
            bool traitee;
            urgent = checkBox1.Checked;
            traitee = false;
            numContain = Convert.ToInt16(comboBox1.Text);
            libelleProb = comboBox2.Text;
            coment = textBoxMotif.Text;
            dateDecla = Convert.ToDateTime(dateTimePicker1.Text);
            
            uneDeclaration.Insert(numContain, libelleProb, coment, dateDecla, urgent, traitee);
            MessageBox.Show("Insertion Réussi");
        }


        private void FormSaisirDeclarationDocker_Load(object sender, EventArgs e)
        {
            List<Containers> collectionContainer = Containers.FetchAll();
            comboBox1.DataSource = collectionContainer;
            comboBox1.ValueMember = "NumContainer";     
            List<Declaration> collectionDeclaration = Declaration.FetchAll();
            comboBox2.Text = "Choisissez votre type de Problème";



        }

        //Retourne à la page d'accueil du logiciel
        private void RetournerVersLeMenuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
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
        //Retourne à la page principal des dockers
        private void rETOURNERVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalDocker()));
            t.Start();
            this.Close();
        }
    }
}
