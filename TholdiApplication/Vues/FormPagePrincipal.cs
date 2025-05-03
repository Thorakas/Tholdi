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

        

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPageConnexion ()) );
            t.Start();
            this.Close();

            

            //Change la valeur de connecté/deconnecté en fonction de si l''utilisateur est connecté
            //if ()
            //{
            //    toolStripMenuItem2.Text = "Se déconnecter";
            //}
        }

        

        //private void button1_Click_1(object sender, EventArgs e)
        //{
        //    Thread t = new Thread(() => Application.Run(new FormPagePrincipalChefEquipe()));
        //    t.Start();
        //    this.Close();
        //}

        //private void button2_Click_1(object sender, EventArgs e)
        //{
        //    Thread t = new Thread(() => Application.Run(new FormPagePrincipalDocker()));
        //    t.Start();
        //    this.Close();
        //}

        private void sITEWEBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("http://www.tholdi.com");
        }

        private void signalerUnProblemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("http://hdesk.tholdi.com/glpi/index.php");
        }

        private void envoyerUnMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            Process.Start("mailto:info@tholdi.com");
        }


        private void Button_Connexion_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPageConnexion()));
            t.Start();
            this.Close();
        }
    }
}
 