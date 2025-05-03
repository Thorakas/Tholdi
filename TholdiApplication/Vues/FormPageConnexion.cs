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
using MySql.Data.MySqlClient;




namespace TholdiApplication
{
    public partial class FormPageConnexion : Form
    {
        public FormPageConnexion()
        {
            InitializeComponent();
        }



        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBoxNomUtilisateur.Text;
            string motDePasse = textBoxMotDePasse.Text;

            if (string.IsNullOrWhiteSpace(textBoxNomUtilisateur.Text) || string.IsNullOrWhiteSpace(textBoxMotDePasse.Text))
            {
                MessageBox.Show("Veuillez saisir un identifiant et un mot de passe.", "Tholdi - Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (MySqlConnection connexion = DataBaseAccess.Connexion)
            {
                try
                {
                    connexion.Open();

                    string query = "SELECT role FROM utilisateur WHERE nom_utilisateur = @nom AND mot_de_passe_hash = @mdp";
                    using (MySqlCommand cmd = new MySqlCommand(query, connexion))
                    {
                        cmd.Parameters.AddWithValue("@nom", nomUtilisateur);
                        cmd.Parameters.AddWithValue("@mdp", motDePasse); // ⚠ Stockage en clair 

                        object result = cmd.ExecuteScalar();

                        if (result != null) // Si l'utilisateur est trouvé
                        {
                            string role = result.ToString();

                            // Redirection selon le rôle
                            Form pageDestination = null;
                            switch (role)
                            {
                                case "docker":
                                    pageDestination = new FormPagePrincipalDocker();
                                    break;
                                case "chefEquipe":
                                    pageDestination = new FormPagePrincipalChefEquipe();
                                    break;                               
                                default:
                                    MessageBox.Show("Rôle inconnu, contactez l'administrateur.");
                                    return;
                            }

                            if (pageDestination != null)
                            {
                                this.Hide();
                                pageDestination.ShowDialog();
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Identifiants incorrects !", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    


    //    if (VerifierIdentifiants(textBoxNomUtilisateur.Text, textBoxMotDePasse.Text))
    //    {                      
    //        Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
    //        t.Start();
    //        this.Close();
    //    }

    //    else
    //    {
    //        MessageBox.Show("Identifiant ou mot de passe incorrect.", "Tholdi - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }
    //}

    //private bool VerifierIdentifiants(string nomUtilisateur, string motDePasse)
    //{
    //    bool estValide = false;

    //    try
    //    {
    //        using (MySqlConnection con = DataBaseAccess.Connexion) // Utilisation de ta classe
    //        {
    //            con.Open();
    //            string query = "SELECT COUNT(*) FROM utilisateur WHERE nom_utilisateur = @nom AND mot_de_passe_hash = @mdp";
    //            using (MySqlCommand cmd = new MySqlCommand(query, con))
    //            {
    //                cmd.Parameters.Add(DataBaseAccess.CodeParam("@nom", nomUtilisateur));
    //                cmd.Parameters.Add(DataBaseAccess.CodeParam("@mdp", motDePasse)); 

    //                int count = Convert.ToInt32(cmd.ExecuteScalar());
    //                estValide = count > 0;
    //            }
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message, "Tholdi - Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //    }

    //    return estValide;
    //}




















    //if (this.textBoxNomUtilisateur.Text == "")
    //{
    //    MessageBox.Show("Veuillez insérer votre nom d'utilisateur et votre mot de passe s'il vous plait ! ", "Tholdi - Avertissement", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
    //}

    //    // Nouvel objet pour instancier la recherche
    //    DirectorySearcher searcher = new DirectorySearcher();

    //    // On modifie le filtre pour ne chercher que l'user dont le nom de login est celui de David ANDRE
    //    searcher.Filter = "(SAMAccountName=dav.and)";

    //    // Pas de boucle foreach car on ne cherche qu'un user
    //    SearchResult result = searcher.FindOne();

    //    // On récupère l'objet trouvé lors de la recherche
    //    DirectoryEntry DirEntry = result.GetDirectoryEntry();

    //    // On vérifie que son nom correspond à ce qu'il y a dans la saisie
    //    if (string.Compare(DirEntry.Properties["sn"].Value.ToString(), textBoxNomUtilisateur.Text) == 0)
    //    {
    //        MessageBox.Show("OK");
    //    }
    //    else
    //        MessageBox.Show("erreur");




    private void FormPageConnexion_Load(object sender, EventArgs e)
        {
            textBoxMotDePasse.UseSystemPasswordChar = true;
            //try
            //{
            //    //connexion à l'annuaire LDAP
            //    DirectoryEntry Ldap = new DirectoryEntry("LDAP://tholdi.com/OU=OU-SSO, DC=tholdi,DC=com", @"GestLDAP", "Xazerty1");

            //    // l'objet DirectorySearcher permet d'effectuer une recherche
            //    DirectorySearcher searcher = new DirectorySearcher(Ldap);

            //    // on filtre pour n'afficher que les utilisateurs
            //    searcher.Filter = "(objectClass=user)";

            //    // pour chaque résultat trouvé
            //    foreach (SearchResult result in searcher.FindAll())
            //    {
            //        // on récupère l'entrée trouvée lors de la recherche
            //        DirectoryEntry DirEntry = result.GetDirectoryEntry();

            //        // on affiche l'info souhaitée dans une liste déroulante
            //        //listBox1.Items.Add("login : " + DirEntry.Properties["SAMAccountName"].Value + " nom : " + DirEntry.Properties["sn"].Value);

            ////    }

            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show("erreur LDAP " + Ex.Message);

            //}    
        }

    private void rETOURVERSLEMENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
            t.Start();
            this.Close();
        }

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

        private void checkBox_Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Show_Hide.Checked)
            {
                textBoxMotDePasse.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxMotDePasse.UseSystemPasswordChar = true;
            }
        }

        private void manuelUtilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://c:\\helpfiles\\help.chm");
        }

        private void textBoxNomUtilisateur_Click(object sender, EventArgs e)
        {
            textBoxNomUtilisateur.Text = "";            
        }

        private void textBoxMotDePasse_Click(object sender, EventArgs e)
        {
            textBoxMotDePasse.Text = "";            
        }
    }
    }

