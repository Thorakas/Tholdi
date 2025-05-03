using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TholdiApplication.Modeles
{
    class Declaration
    {
        private long numDeclaration;
        private string commentaire;
        private DateTime dateDeclaration;
        private string libelleProbleme;
        private bool urgence;
        private bool traite;
        private Containers unContainer;
        #region Propriété
        public long NumDeclaration
        {
            get
            {
                return numDeclaration;
            }
        }

        public string Commentaire
        {
            get
            {
                return commentaire;
            }

            set
            {
                commentaire = value;
            }
        }

        public DateTime DateDeclaration
        {
            get
            {
                return dateDeclaration;
            }

            set
            {
                dateDeclaration = value;
            }
        }

        public bool Urgence
        {
            get
            {
                return urgence;
            }

            set
            {
                urgence = value;
            }
        }

        public bool Traite
        {
            get
            {
                return traite;
            }

            set
            {
                traite = value;
            }
        }

        public Containers Container
        {
            get
            {
                return unContainer;
            }

            set
            {
                unContainer = value;
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
        #endregion
        //public Declaration(string commentaire, Probleme probleme, bool urgence, bool traite, Containers container)
        //{
        //    this.Commentaire = commentaire;
        //    this.DateDeclaration = DateTime.Now;
        //    this.Urgence = urgence;
        //    this.Traite = traite;
        //    this.Probleme = probleme;
        //    this.Container = container;
        //}

        #region Champs à portée classe contenant l'ensemble des requêtes d'accès aux données
        private static string _selectSql =
            "SELECT CODEDECLARATION, NUMCONTAINER, LIBELLEPROBLEME, COMMENTAIRE, DATEDECLARATION, URGENCE, TRAITE FROM declaration";

        private static string _selectByIdSql =
            "SELECT CODEDECLARATION, COMMENTAIRE, DATEDECLARATION, URGENCE, TRAITE, CODEPROBLEME, NUMCONTAINER FROM declaration WHERE CODEDECLARATION = ?CodeDeclaration ";

        private static string _updateSql =
            "UPDATE declaration SET COMMENTAIRE = ?Commentaire, DATEDECLARATION=?DateDeclaration , URGENCE=?Urgence, TRAITE=?Traite, CODEPROBLEME=?CodeProbleme, NUMCONTAINER=?NumContainer  WHERE CODEDECLARATION=?CodeDeclaration ";

        private static string _insertSql =
            "INSERT into declaration (NUMCONTAINER, LIBELLEPROBLEME, COMMENTAIRE, DATEDECLARATION, URGENCE, TRAITE) VALUES (?NUMCONTAINER, ?LIBELLEPROBLEME, ?COMMENTAIRE, ?DATEDECLARATION, ?URGENCE, ?TRAITE )";

        private static string _deleteByIdSql =
            "DELETE FROM declaration WHERE CODEDECLARATION = ?CodeDeclaration";

        private static string _getLastInsertId =
            "SELECT CODEDECLARATION FROM declaration WHERE COMMENTAIRE = ?Commentaire AND DATEDECLARATION=?DateDeclaration AND URGENCE=?Urgence AND TRAITE=?Traite AND CODEPROBLEME=?CodeProbleme AND NUMCONTAINER=?NumContainer";



        #endregion

        #region Méthodes de lien avec la base de donnée

        /// <summary>
        /// Valorise un objet contact depuis le système de gestion de bases de données
        /// </summary>
        /// <param name="numDeclaration">La valeur de la clé primaire</param>
        public static Declaration Fetch(int numDeclaration)
        {
            Declaration d = null;
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();//Initialisation d'un objet permettant d'interroger la bd
            commandSql.CommandText = _selectByIdSql;//Définit la requete à utiliser
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?CODEDECLARATION", numDeclaration));//Transmet un paramètre à utiliser lors de l'envoie de la requête
            commandSql.Prepare();//Prépare la requête (modification du paramètre de la requête)
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();//Exécution de la requête
            bool existEnregistrement = jeuEnregistrements.Read();//Lecture du premier enregistrement
            if (existEnregistrement)//Si l'enregistrement existe
            {//alors
                d = new Declaration();//Initialisation de la variable Client
                d.numDeclaration = Convert.ToInt16(jeuEnregistrements["CODEDECLARATION"].ToString());//Lecture d'un champ de l'enregistrement
                string numContain = jeuEnregistrements["NUMCONTAINER"].ToString();
                d.unContainer = Containers.Fetch(Convert.ToInt32(numContain));
                d.LibelleProbleme = jeuEnregistrements["LIBELLEPROBLEME"].ToString();
                d.commentaire = jeuEnregistrements["COMMENTAIRE"].ToString();
                d.dateDeclaration = Convert.ToDateTime(jeuEnregistrements["DATEDECLARATION"].ToString());
                d.urgence = Convert.ToBoolean(jeuEnregistrements["URGENCE"].ToString());
                d.traite = Convert.ToBoolean(jeuEnregistrements["TRAITE"].ToString());

            }
            msc.Close();//fermeture de la connexion
            return d;
        }

        /// <summary>
        /// Retourne une collection contenant les contacts
        /// </summary>
        /// <returns>Une collection de contacts</returns>
        public static List<Declaration> FetchAll()
        {
            List<Declaration> resultat = new List<Declaration>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSql;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Declaration d = new Declaration();
                d = new Declaration();//Initialisation de la variable Client
                d.numDeclaration = Convert.ToInt16(jeuEnregistrements["CODEDECLARATION"].ToString());//Lecture d'un champ de l'enregistrement
                d.LibelleProbleme = jeuEnregistrements["LIBELLEPROBLEME"].ToString();
                d.commentaire = jeuEnregistrements["COMMENTAIRE"].ToString();
                d.dateDeclaration = Convert.ToDateTime(jeuEnregistrements["DATEDECLARATION"].ToString());
                d.commentaire = jeuEnregistrements["COMMENTAIRE"].ToString();
                d.urgence = Convert.ToBoolean(jeuEnregistrements["URGENCE"].ToString());
                d.traite = Convert.ToBoolean(jeuEnregistrements["TRAITE"].ToString());
                string numContain = jeuEnregistrements["NUMCONTAINER"].ToString();
                d.unContainer = Containers.Fetch(Convert.ToInt32(numContain));
                resultat.Add(d);

            }
            msc.Close();
            return resultat;
        }


        public void  Insert(long numContainer, string libelleProbleme, string comment, DateTime dateDecla, bool urgence, bool traite)
        {
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _insertSql;
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMCONTAINER", numContainer));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEPROBLEME", libelleProbleme));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?COMMENTAIRE", comment));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?DATEDECLARATION", dateDecla));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?URGENCE", urgence));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?TRAITE", traite));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();
            numDeclaration = commandSql.LastInsertedId;
            msc.Close();
        }
    
        #endregion


    }
}