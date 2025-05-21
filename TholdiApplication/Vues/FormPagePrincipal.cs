using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TholdiApplication.Modeles;
using TholdiApplication.Vues;
using MySql.Data;
using System.Diagnostics;


namespace TholdiApplication.Vues
{
    public partial class FormPagePrincipal : Form
    {
        public FormPagePrincipal()
        {
            InitializeComponent();
        }
             
        private void signalerUnProblemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("");
        }

        private void envoyerUnMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("mailto:info@tholdi.com");
        }

        //Bouton qui envoie au formulaire de connexion
        private void Button_Connexion_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPageConnexion()));
            t.Start();
            this.Close();
        }
    }
}
 