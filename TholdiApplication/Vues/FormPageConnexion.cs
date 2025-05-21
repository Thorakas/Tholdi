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
using BCrypt.Net;




namespace TholdiApplication
{
    public partial class FormPageConnexion : Form
    {
        public FormPageConnexion()
        {
            InitializeComponent();
        }


        //Bouton de connexion, accès au logiciel si compte existant et MDP correct. Redirige vers une page d'accueil différente en fonction du role de l'utilisateur
        private void boutonConnexion_Click(object sender, EventArgs e)
        {
            string nomUtilisateur = textBoxNomUtilisateur.Text;
            string motDePasse = textBoxMotDePasse.Text;

            if (string.IsNullOrWhiteSpace(nomUtilisateur) || string.IsNullOrWhiteSpace(motDePasse))
            {
                MessageBox.Show("Veuillez saisir un identifiant et un mot de passe.", "Tholdi - Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection connexion = DataBaseAccess.Connexion)
            {
                try
                {
                    connexion.Open();

                    string query = "SELECT mot_de_passe, role FROM utilisateur WHERE nom_utilisateur = @nom";
                    using (MySqlCommand cmd = new MySqlCommand(query, connexion))
                    {
                        cmd.Parameters.AddWithValue("@nom", nomUtilisateur);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashStocke = reader.GetString("mot_de_passe");
                                string role = reader.GetString("role");
                                //Décryptage du MDP hashé, compare mdp inséré avec mdp en BDD
                                if (BCrypt.Net.BCrypt.Verify(motDePasse, hashStocke))
                                {                                    
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
                                            MessageBox.Show("Rôle inconnu");
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
                                    MessageBox.Show("Mot de passe incorrect !", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Utilisateur non trouvé !", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de connexion : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


    private void FormPageConnexion_Load(object sender, EventArgs e)
        {
            textBoxMotDePasse.UseSystemPasswordChar = true;              
        }

        //Retourne à la page d'accueil du logiciel
        private void rETOURVERSLEMENUPRINCIPALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(() => Application.Run(new FormPagePrincipal()));
            t.Start();
            this.Close();
        }

        //Retourne à la page d'accueil du logiciel
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

        //Checkbox qui permet d'afficher le mot de passe en clair
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

