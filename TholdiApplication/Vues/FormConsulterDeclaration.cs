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

namespace TholdiApplication.Vues
{
    public partial class FormConsulterDeclaration : Form
    {
        public FormConsulterDeclaration()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormConsulterDeclaration_Load(object sender, EventArgs e)
        {
            List<Declaration> collectionDeclaration = Declaration.FetchAll();
            dataGridView1.DataSource = collectionDeclaration;
        }

        private void rETOURVERSLINTERFACEDESDOCKERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipalDocker()));
            t.Start();
            this.Close();
        }

        private void rETOURVERSLEMENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
            t.Start();
            this.Close();
        }
    }
}
