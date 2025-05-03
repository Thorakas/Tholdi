using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TholdiApplication.Modeles
{
    class Probleme
    {
        #region champs
        private short codeProbleme;
        private string libelleProbleme;
        public Probleme()
        {
            codeProbleme = -1;
        }

        public short CodeProbleme
        {
            get
            {
                return codeProbleme;
            }
        }

        public string LibelleProbleme
        {
            get
            {
                return libelleProbleme;
            }

            set
            {
                libelleProbleme = value;
            }
        }
        public override string ToString()
        {
            return String.Format("LIBELLEPROBLEME : {0}  ", libelleProbleme);
        }
        #endregion

        //public Probleme(string libelleProbleme)
        //{
        //    this.LibelleProbleme = libelleProbleme;

        //}
        #region Champs à portée classe contenant l'ensemble des requêtes d'accès aux données
        private static string _selectpProblemeSql =
            "SELECT CODEPROBLEME, LIBELLEPROBLEME FROM probleme";

        private static string _selectByIdSql =
            "SELECT id , prenom, nom ,  telephone , email FROM probleme WHERE id = ?id ";

        private static string _updateSql =
            "UPDATE contact SET prenom = ?prenom, nom=?nom , telephone=?telephone, email=?email  WHERE id=?id ";

        private static string _insertSql =
            "INSERT INTO probleme (prenom,nom,email,telephone) VALUES (?prenom,?nom,?email,?telephone)";

        private static string _deleteByIdSql =
            "DELETE FROM probleme WHERE id = ?id";

        private static string _getLastInsertId =
            "SELECT id FROM probleme WHERE prenom = ?prenom AND nom=?nom AND telephone=?telephone AND email=?email  ";




        #endregion
        #region Méthodes de lien avec la base de donnée

        /// <summary>
        /// Valorise un objet contact depuis le système de gestion de bases de données
        /// </summary>
        /// <param name="codeProbleme">La valeur de la clé primaire</param>
        public static Probleme Fetch(int codeProbleme)
        {
            Probleme p = null;
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();//Initialisation d'un objet permettant d'interroger la bd
            commandSql.CommandText = _selectByIdSql;//Définit la requete à utiliser
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?CODEPROBLEME", codeProbleme));//Transmet un paramètre à utiliser lors de l'envoie de la requête
            commandSql.Prepare();//Prépare la requête (modification du paramètre de la requête)
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();//Exécution de la requête
            bool existEnregistrement = jeuEnregistrements.Read();//Lecture du premier enregistrement
            if (existEnregistrement)//Si l'enregistrement existe
            {//alors
                p = new Probleme();//Initialisation de la variable Client
                p.codeProbleme = Convert.ToInt16(jeuEnregistrements["CODEPROBLEME"].ToString());//Lecture d'un champ de l'enregistrement
                p.libelleProbleme = jeuEnregistrements["LIBELLEPROBLEME"].ToString();
            }
            msc.Close();//fermeture de la connexion
            return p;
        }

        /// <summary>
        /// Retourne une collection contenant les contacts
        /// </summary>
        /// <returns>Une collection de contacts</returns>
        public static List<Probleme> FetchAll()
        {
            List<Probleme> resultat = new List<Probleme>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectpProblemeSql;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Probleme p = new Probleme();
                string codeProblemo = jeuEnregistrements["CODEPROBLEME"].ToString();
                p.codeProbleme = Convert.ToInt16(codeProblemo);
                p.libelleProbleme = jeuEnregistrements["LIBELLEPROBLEME"].ToString();
                resultat.Add(p);
            }
            msc.Close();
            return resultat;
        }
        #endregion

    }
}