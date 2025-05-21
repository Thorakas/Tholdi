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
    public partial class FormPagePrincipalChefEquipe : Form
    {
        public FormPagePrincipalChefEquipe()
        {
            InitializeComponent();
        }

        // Envoie au formulaire qui permet de voir les problèmes remonté par les Dockers (sous-menu "Consulter les problèmes")
        private void prévoirUneInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Thread t = new Thread(() => Application.Run(new FormConsulterProbleme()));
            t.Start();
            this.Close();
        }

        // Envoie au formulaire qui permet de créer une inspection sur un container
        private void saisirUneInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormSaisirInspectionChef()));
            t.Start();
            this.Close();
        }

        // Envoie au formulaire qui permet voir les inspections prévues
        private void consulterUneInspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormConsulterInspection()));
            t.Start();
            this.Close();
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

       

       
    }
}
