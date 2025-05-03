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
    public partial class FormSaisirInspectionChef : Form
    {
        public FormSaisirInspectionChef()
        {
            InitializeComponent();
        }




        private void FormSaisirInspectionChef_Load(object sender, EventArgs e)
        {

            //List<Inspection> collectionInspection = Inspection.FetchAll();

            //comboBox2.DataSource = collectionInspection;
            //comboBox2.DisplayMember = "NumeroInspection";
            //comboBox2.Text = "Numéro de l'inspection";
            //List<Containers> collectionContainer = Containers.FetchAll();
            //comboBox1.DataSource = collectionContainer;
            //comboBox1.ValueMember = "NumContainer";
            //comboBox1.Text = "Numéro du Container";
            //comboBox3.Text = "Choisissez votre motif";
            //comboBox4.Text = "Choisissez l'état de l'inspection";
        }

       

        private void button1_Click(object sender, EventArgs e)//Faire une action pour permettre a l'utilisateur de savoir que l'insertion a bien fonctionner
        {


            if ( comboBox1.Text == "" || comboBox3.Text =="" || comboBox4.Text == "" || textBoxCommentaire.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs avant de valider.");
                return;
            }

                    
            Inspection uneInspection = new Inspection();
            long numContain = 0;
            //long numInspection = 0;
            string unMotif;
            string unEtat;
            DateTime dateInpes;
            string uncommentaire;
            string unAvis;
            numContain = Convert.ToInt16(comboBox1.Text);
            //numInspection = Convert.ToInt16(textBox2.Text);
            unMotif = comboBox3.Text;
            unEtat = comboBox4.Text;
            dateInpes = Convert.ToDateTime(dateInspection.Text);
            uncommentaire = textBoxCommentaire.Text;
            unAvis = textBoxCommentaire.Text;
            uneInspection.Insert(numContain, unMotif, unEtat, dateInpes, uncommentaire, unAvis);
            MessageBox.Show("Insertion Réussi");
        

        }

        private void rETOURNERPAGEPRINCIPALEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
            t.Start();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rETOURNERVERSLINTERFACEDESCHEFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalChefEquipe()));
            t.Start();
            this.Close();
        }
    }
}
