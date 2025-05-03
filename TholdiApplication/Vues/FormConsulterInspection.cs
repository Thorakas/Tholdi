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
    public partial class FormConsulterInspection : Form
    {
        public FormConsulterInspection()
        {
            InitializeComponent();
        }
        
        private void FormConsulterInspection_Load(object sender, EventArgs e)
        {
            List<Inspection> collectionInspectionPrevue = Inspection.FetchAllPrevue();
            dataGridView1.DataSource = collectionInspectionPrevue;
            List<Inspection> collectionInspectionEnCours = Inspection.FetchAllEncours();
            dataGridView2.DataSource = collectionInspectionEnCours;
            List<Inspection> collectionInspectionFinie = Inspection.FetchAllFinie();
            dataGridView3.DataSource = collectionInspectionFinie;

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdxLigneActuelle = e.RowIndex;
            DataGridViewRow ligne = dataGridView1.Rows[IdxLigneActuelle];
            string valeur = ligne.Cells[4].Value.ToString();
        }


        //bouton affecter aux inspections
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                
                    Inspection inspectionSelectionnee = (Inspection)dataGridView1.CurrentRow.DataBoundItem;

                    if (inspectionSelectionnee.LibelleEtat == "Prevue")
                    {
                       
                        inspectionSelectionnee.LibelleEtat = "En cours";

                        
                        inspectionSelectionnee.UpdateInspect();

                        
                        FormConsulterInspection_Load(sender, e);

                        MessageBox.Show("L'inspection a été mise à jour en 'En cours' avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Seules les inspections prévues peuvent être mises à jour en 'En cours'.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une inspection à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


            

        }

        private void rETOURVERSLEMENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void rETOURNERVERSLINTERFACEDESCHEFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalChefEquipe()));
            t.Start();
            this.Close();
        }

        //bouton Affecter aux inspections achevées
        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView2.SelectedRows.Count > 0)
            {
                

                Inspection inspectionSelectionnee = (Inspection)dataGridView2.CurrentRow.DataBoundItem;


                
                if (inspectionSelectionnee.LibelleEtat == "En cours")
                {                    
                    inspectionSelectionnee.LibelleEtat = "Finie";                    
                    inspectionSelectionnee.UpdateInspect();                   
                    FormConsulterInspection_Load(sender, e);
                    MessageBox.Show("L'inspection a été mise à jour en 'Finie' avec succès !");
                }
                else
                {
                    MessageBox.Show("Seules les inspections en cours peuvent être mises à jour en 'Finie'.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une inspection à modifier.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // bouton Décision
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
