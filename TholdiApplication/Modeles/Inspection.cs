using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace TholdiApplication.Modeles
{
    [Serializable]
    /// <summary>
    /// Classe Inspection : Représente une inspection
    /// </summary>
    class Inspection
    {
        private long _numContainer;
        private long _numInspection;
        private string _libelleMotif;
        private string _libelleEtat;
        private DateTime _dateInspection;
        private string _commentairePostInspection;
        private string _avis;
        private List<Containers> _lesContainers;
        private List<Motif> _lesMotifs;
        private List<Etat> _lesEtats;

        /// <summary>
        /// Obtient la collection de containers
        /// </summary>
        /// <remarks>La collection est en lecture seule</remarks>
        //public ReadOnlyCollection<Containers> Container
        //{
        //    get
        //    {
        //        return new ReadOnlyCollection<Containers>(_lesContainers);
        //    }

        //}
        ///// <summary>
        ///// Obtient la collection de motifs
        ///// </summary>
        ///// <remarks>La collection est en lecture seule</remarks>
        //public ReadOnlyCollection<Motif> Motif
        //{
        //    get
        //    {
        //        return new ReadOnlyCollection<Motif>(_lesMotifs);
        //    }

        //}
        ///// <summary>
        ///// Obtient la collection d'états
        ///// </summary>
        ///// <remarks>La collection est en lecture seule</remarks>
        //public ReadOnlyCollection<Etat> Etat
        //{
        //    get
        //    {
        //        return new ReadOnlyCollection<Etat>(_lesEtats);
        //    }
        //}

        //}
        /// <summary>
        /// Obtient le numéro du container
        /// </summary>
        public long NumeroContainer
        {
            get { return _numContainer; }
        }
        /// <summary>
        /// Obtient le numéro de l'inspection 
        /// </summary>
        public long NumeroInspection
        {
            get { return _numInspection; }
        }
        /// <summary>
        /// Obtient le code du motif
        /// </summary>
        public string LibelleMotif
        {
            get { return _libelleMotif; }
        }
        /// <summary>
        /// Obtient le code d'état
        /// </summary>
        public string LibelleEtat
        {
            get { return _libelleEtat; }
            set { _libelleEtat = value; }
        }
        /// <summary>
        /// Obtient ou définit la date de l'inspection
        /// </summary>
        public DateTime DateInspection
        {
            get { return _dateInspection; }
            set { _dateInspection = value; }
        }
        /// <summary>
        /// Obtient ou définit le commentaire 
        /// </summary>
        public string Commentaire
        {
            get { return _commentairePostInspection; }
            set { _commentairePostInspection = value; }
        }
        /// <summary>
        /// Obtient ou définit l'avis
        /// </summary>
        public string Avis
        {
            get { return _avis; }
            set { _commentairePostInspection = value; }
        }
        //public override string ToString()
        //{
        //    return String.Format("DATEINSPECTION, NUMINSPECTION, NUMCONTAINER  : {0}, {1}, {2}", DateInspection, NumeroInspection, NumeroContainer);
        //}

        /// <summary>
        /// Initialise une inspection
        /// </summary>
        /// <param name="numContainer">Le numéro du container</param>
        /// <param name="numInspection">Le numéro de l'inspection</param>
        /// <param name="codeMotif">Le code du motif</param>
        /// <param name="codeEtat">Le code de l'état</param>
        /// <param name="dateInspection">La date de l'inspection</param>
        /// <param name="commentairePostInspection">Le commentaire post inspection</param>
        /// <param name="avis">L'avis de l'inspection</param>
        //public Inspection(long numContainer, long numInspection, long codeMotif, long codeEtat, DateTime dateInspection, string commentaire, string avis)
        //{
        //    _numContainer = numContainer;
        //    _numInspection = numInspection;
        //    _codeMotif = codeMotif;
        //    _codeEtat = codeEtat;
        //    _dateInspection = dateInspection;
        //    _commentairePostInspection = commentaire;
        //    _avis = avis;
        //}
        #region Champs à portée classe contenant l'ensemble des requêtes d'accès aux données
        private static string _selectSql =
                    "SELECT NUMCONTAINER, NUMINSPECTION, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS FROM inspection";
        private static string _selectByNumContainerSql =
            "SELECT NUMCONTAINER, NUMINSPECTION, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS FROM inspection WHERE NUMCONTAINER = ?NUMCONTAINER";

        private static string _updateSql =
            "UPDATE inspection SET LIBELLEMOTIF = ?LIBELLEMOTIF, LIBELLEETAT = ?LIBELLEETAT, DATEINSPECTION = ?DATEINSPECTION, COMMENTAIREPOSTINSPECTION = ?COMMENTAIREPOSTINSPECTION, AVIS = ?AVIS WHERE id=?id ";

        private static string _updateSqlEncours =
          "UPDATE inspection SET LIBELLEETAT = ?LIBELLEETAT WHERE NUMINSPECTION = ?NUMINSPECTION ";

        private static string _insertSql =
            "INSERT into inspection (NUMCONTAINER, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS) VALUES (?NUMCONTAINER, ?LIBELLEMOTIF, ?LIBELLEETAT, ?DATEINSPECTION, ?COMMENTAIREPOSTINSPECTION, ?AVIS )";

        private static string _deleteByNumInspectionSql =
            "DELETE FROM inspection WHERE NUMINSPECTION = ?NUMINSPECTION AND NUMCONTAINER = ?NUMCONTAINER";

        private static string _getLastInsertNumInspection =
            "SELECT NUMINSPECTION FROM INSPECTION WHERE NUMCONTAINER=?NUMCONTAINER AND LIBELLEMOTIF=?LIBELLEMOTIF AND LIBELLEETAT=?LIBELLEETAT AND DATEINSPECTION=?DATEINSPECTION AND COMMENTAIREPOSTINSPECTION=?COMMENTAIREPOSTINSPECTION AND AVIS=?AVIS";
        private static string _selectSqlInspectionPrevue =
            "SELECT NUMCONTAINER, NUMINSPECTION, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS FROM inspection WHERE LIBELLEETAT = 'prévue'";
        private static string _selectSqlInspectionEncours =
           "SELECT NUMCONTAINER, NUMINSPECTION, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS FROM inspection WHERE LIBELLEETAT = 'En cours'";
        private static string _selectSqlInspectionFinie =
           "SELECT NUMCONTAINER, NUMINSPECTION, LIBELLEMOTIF, LIBELLEETAT, DATEINSPECTION, COMMENTAIREPOSTINSPECTION, AVIS FROM inspection WHERE LIBELLEETAT = 'finie'";

        #endregion

        #region Méthodes de lien avec la base de donnée

        /// <summary>
        /// Valorise un objet contact depuis le système de gestion de bases de données
        /// </summary>
        /// <param name="codeProbleme">La valeur de la clé primaire</param>
        //public static Inspection Fetch(long codeProbleme)
        //{
        //    Probleme p = null;
        //    MySqlConnection msc = DataBaseAccess.Connexion;
        //    msc.Open();
        //    MySqlCommand commandSql = msc.CreateCommand();//Initialisation d'un objet permettant d'longerroger la bd
        //    commandSql.CommandText = _selectByIdSql;//Définit la requete à utiliser
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?CODEPROBLEME", codeProbleme));//Transmet un paramètre à utiliser lors de l'envoie de la requête
        //    commandSql.Prepare();//Prépare la requête (modification du paramètre de la requête)
        //    MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();//Exécution de la requête
        //    bool existEnregistrement = jeuEnregistrements.Read();//Lecture du premier enregistrement
        //    if (existEnregistrement)//Si l'enregistrement existe
        //    {//alors
        //        p = new Probleme();//Initialisation de la variable Client
        //        p.codeProbleme = Convert.Tolong16(jeuEnregistrements["CODEPROBLEME"].ToString());//Lecture d'un champ de l'enregistrement
        //        p.libelleProbleme = jeuEnregistrements["LIBELLEPROBLEME"].ToString();
        //    }
        //    msc.Close();//fermeture de la connexion
        //    return p;
        //}

        /// <summary>
        /// Retourne une collection contenant les contacts
        /// </summary>
        /// <returns>Une collection de contacts</returns>
        public static List<Inspection> FetchAll()
        {
            List<Inspection> resultat = new List<Inspection>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSql;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Inspection p = new Inspection();
                string numcontaino = jeuEnregistrements["NUMCONTAINER"].ToString();
                p._numContainer = Convert.ToInt16(numcontaino);
                string numInpsec = jeuEnregistrements["NUMINSPECTION"].ToString();
                p._numInspection = Convert.ToInt16(numInpsec);
                p._libelleMotif = jeuEnregistrements["LIBELLEMOTIF"].ToString();
                p._libelleEtat = jeuEnregistrements["LIBELLEETAT"].ToString();
                p._dateInspection = Convert.ToDateTime(jeuEnregistrements["DATEINSPECTION"].ToString());
                p._commentairePostInspection = jeuEnregistrements["COMMENTAIREPOSTINSPECTION"].ToString();
                p._avis = jeuEnregistrements["AVIS"].ToString();


                resultat.Add(p);
            }
            msc.Close();
            return resultat;
        }// Recupère toutes les inspections
        public static List<Inspection> FetchAllPrevue()
        {
            List<Inspection> resultat = new List<Inspection>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSqlInspectionPrevue;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Inspection p = new Inspection();
                string numcontaino = jeuEnregistrements["NUMCONTAINER"].ToString();
                p._numContainer = Convert.ToInt16(numcontaino);
                string numInpsec = jeuEnregistrements["NUMINSPECTION"].ToString();
                p._numInspection = Convert.ToInt16(numInpsec);
                p._libelleMotif = jeuEnregistrements["LIBELLEMOTIF"].ToString();
                p._libelleEtat = jeuEnregistrements["LIBELLEETAT"].ToString();
                p._dateInspection = Convert.ToDateTime(jeuEnregistrements["DATEINSPECTION"].ToString());
                p._commentairePostInspection = jeuEnregistrements["COMMENTAIREPOSTINSPECTION"].ToString();
                p._avis = jeuEnregistrements["AVIS"].ToString();


                resultat.Add(p);
            }
            msc.Close();
            return resultat;
        }// Recupère toutes les inspections Prévue
        public static List<Inspection> FetchAllEncours()
        {
            List<Inspection> resultat = new List<Inspection>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSqlInspectionEncours;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Inspection p = new Inspection();
                string numcontaino = jeuEnregistrements["NUMCONTAINER"].ToString();
                p._numContainer = Convert.ToInt16(numcontaino);
                string numInpsec = jeuEnregistrements["NUMINSPECTION"].ToString();
                p._numInspection = Convert.ToInt16(numInpsec);
                p._libelleMotif = jeuEnregistrements["LIBELLEMOTIF"].ToString();
                p._libelleEtat = jeuEnregistrements["LIBELLEETAT"].ToString();
                p._dateInspection = Convert.ToDateTime(jeuEnregistrements["DATEINSPECTION"].ToString());
                p._commentairePostInspection = jeuEnregistrements["COMMENTAIREPOSTINSPECTION"].ToString();
                p._avis = jeuEnregistrements["AVIS"].ToString();


                resultat.Add(p);
            }
            msc.Close();
            return resultat;
        }// Recupère toutes les inspections En cours
        public static List<Inspection> FetchAllFinie()
        {
            List<Inspection> resultat = new List<Inspection>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSqlInspectionFinie;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Inspection p = new Inspection();
                string numcontaino = jeuEnregistrements["NUMCONTAINER"].ToString();
                p._numContainer = Convert.ToInt16(numcontaino);
                string numInpsec = jeuEnregistrements["NUMINSPECTION"].ToString();
                p._numInspection = Convert.ToInt16(numInpsec);
                p._libelleMotif = jeuEnregistrements["LIBELLEMOTIF"].ToString();
                p._libelleEtat = jeuEnregistrements["LIBELLEETAT"].ToString();
                p._dateInspection = Convert.ToDateTime(jeuEnregistrements["DATEINSPECTION"].ToString());
                p._commentairePostInspection = jeuEnregistrements["COMMENTAIREPOSTINSPECTION"].ToString();
                p._avis = jeuEnregistrements["AVIS"].ToString();


                resultat.Add(p);
            }
            msc.Close();
            return resultat;
        }// Recrupère toutes les inspections Finie

        //public static void Insert(long numContainer, string Etat, string motif, DateTime inspec, string comment, string avis)
        //{
        //    MySqlConnection msc = DataBaseAccess.Connexion;
        //    msc.Open();
        //    MySqlCommand commandSql = msc.CreateCommand();
        //    commandSql.CommandText = _insertSql;
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMCONTAINER", numContainer));
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEMOTIF", Etat));
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEETAT", motif));
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?DATEINSPECTION", inspec));
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?COMMENTAIREPOSTINSPECTION", comment));
        //    commandSql.Parameters.Add(DataBaseAccess.CodeParam("?AVIS", avis));
        //    commandSql.Prepare();
        //    commandSql.ExecuteNonQuery();
        //     = commandSql.LastInsertedId;
        //    msc.Close();
        //}

        public void Insert(long numContainer, string Etat, string motif, DateTime inspec, string comment, string avis)
        {
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _insertSql;
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMCONTAINER", numContainer));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEMOTIF", Etat));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEETAT", motif));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?DATEINSPECTION", inspec));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?COMMENTAIREPOSTINSPECTION", comment));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?AVIS", avis));
            commandSql.Prepare();
            commandSql.ExecuteNonQuery();
            _numInspection = commandSql.LastInsertedId;
            msc.Close();
        }

        public void UpdateInspect()
        {
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _updateSqlEncours;
            
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEETAT", LibelleEtat));
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMINSPECTION", NumeroInspection));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMCONTAINER", _numContainer));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMINSPECTION", _numInspection));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEMOTIF", _libelleEtat));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?LIBELLEETAT", _libelleMotif));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?DATEINSPECTION", _dateInspection));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?COMMENTAIREPOSTINSPECTION", _commentairePostInspection));
            //commandSql.Parameters.Add(DataBaseAccess.CodeParam("?AVIS", _avis));

            commandSql.Prepare();
            commandSql.ExecuteNonQuery();
            msc.Close();

        }//En cours j'essaye de recuperer les données qui se trouve dans le datagridWiew
        //UPDATE INSPECTION SET LIBELLEETAT = "en cours" WHERE NUMINSPECTION = 1
        #endregion
    }
}
