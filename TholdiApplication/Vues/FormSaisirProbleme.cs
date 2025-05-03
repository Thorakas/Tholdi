using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TholdiApplication.Modeles;
using TholdiApplication.Vues;

namespace TholdiApplication.Vues
{
    public partial class FormSaisirProbleme : Form
    {
        public FormSaisirProbleme()
        {
            InitializeComponent();
        }

        private void FormSaisirProbleme_Load(object sender, EventArgs e)
        {
            List<Probleme> collectionProbleme = Probleme.FetchAll();
            listBox1.DataSource = collectionProbleme;
            listBox1.ValueMember = "CODEPROBLEME";
            listBox3.DataSource = collectionProbleme;
            listBox3.ValueMember = "LIBELLEPROBLEME";
            List<Containers> collectionContainer = Containers.FetchAll();
            listBox2.DataSource = collectionContainer;
            listBox2.ValueMember = "NUMCONTAINER";

        }
    }
}
