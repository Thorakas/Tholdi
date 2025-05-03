using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TholdiApplication.Modeles
{
    class Containers
    {
        private short _numContainer;
        private DateTime _dateAchat;
        private DateTime _dateLimite;
        private String _typeContainer;

        #region Propriété

        public short NumContainer
        {
            get { return _numContainer; }
        }
        public Containers()
        {
            _numContainer = -1;
        }

        public DateTime DateAchat
        {
            get { return _dateAchat; }
        }
        public DateTime DateLimite
        {
            get { return _dateLimite; }
        }
        public string TypeContainer
        {
            get { return _typeContainer; }
            set { _typeContainer = value; }
        }

        //public Container(int numContainer, DateTime dateAchat, DateTime DateLimite, string typeContainer)
        //{
        //    _numContainer = numContainer;
        //    _dateAchat = dateAchat;
        //    _dateLimite = DateLimite;
        //    _typeContainer = typeContainer;
        //}
        #endregion


        #region Requêtes SQL sur la classe Container
        private static string _selectSql =
            "SELECT NUMCONTAINER, DATEACHAT, TYPECONTAINER, DATELIMITEPROCHINSP from container";

        private static string _selectByNumContainerSql =
            "SELECT NUMCONTAINER, DATEACHAT, TYPECONTAINER, DATELIMITEPROCHINSP from container where NUMCONTAINER = ?numcontainer";

        private static string _updateSql =
            "UPDATE container SET DATEACHAT=?dateachat , TYPECONTAINER=?typecontainer, DATELIMITEPROCHINSP=?datelimiteprochinsp  WHERE NUMCONTAINER=?numcontainer";

        private static string _insertSql =
            "INSERT INTO container (NUMCONTAINER, DATEACHAT, TYPECONTAINER, DATELIMITEPROCHINSP) VALUES (?numcontainer,?dateachat,?typecontainer,?datelimiteprochainsp)";

        private static string _deleteByNumContainerSql =
            "DELETE FROM container WHERE NUMCONTAINER = ?numcontainer";

        private static string _getLastInsertNumContainer =
            "SELECT NUMCONTAINER FROM container WHERE DATEACHAT = ?dateachat AND TYPECONTAINER=?typecontainer AND DATELIMITEPROCHINSP=?datelimiteprochinsp";
        #endregion

        #region Méthodes de lien avec la base de donnée

        /// <summary>
        /// Valorise un objet contact depuis le système de gestion de bases de données
        /// </summary>
        /// <param name="codeProbleme">La valeur de la clé primaire</param>
        public static Containers Fetch(int numContainer)
        {
            Containers c = null;
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();//Initialisation d'un objet permettant d'interroger la bd
            commandSql.CommandText = _selectByNumContainerSql;//Définit la requete à utiliser
            commandSql.Parameters.Add(DataBaseAccess.CodeParam("?NUMCONTAINER", numContainer));//Transmet un paramètre à utiliser lors de l'envoie de la requête
            commandSql.Prepare();//Prépare la requête (modification du paramètre de la requête)
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();//Exécution de la requête
            bool existEnregistrement = jeuEnregistrements.Read();//Lecture du premier enregistrement
            if (existEnregistrement)//Si l'enregistrement existe
            {//alors
                c = new Containers();//Initialisation de la variable Client
                c._numContainer = Convert.ToInt16(jeuEnregistrements["NUMCONTAINER"].ToString());//Lecture d'un champ de l'enregistrement
                c._dateAchat = Convert.ToDateTime(jeuEnregistrements["DATEACHAT"].ToString());
                c._dateLimite = Convert.ToDateTime(jeuEnregistrements["DATELIMITEPROCHINSP"].ToString());
                c._typeContainer = jeuEnregistrements["TYPECONTAINER"].ToString();
            }
            msc.Close();//fermeture de la connexion
            return c;
        }//Recrupère un container en fonction de son numéro de container

        /// <summary>
        /// Retourne une collection contenant les contacts
        /// </summary>
        /// <returns>Une collection de contacts</returns>
        public static List<Containers> FetchAll()
        {
            List<Containers> resultat = new List<Containers>();
            MySqlConnection msc = DataBaseAccess.Connexion;
            msc.Open();
            MySqlCommand commandSql = msc.CreateCommand();
            commandSql.CommandText = _selectSql;
            MySqlDataReader jeuEnregistrements = commandSql.ExecuteReader();
            while (jeuEnregistrements.Read())
            {
                Containers c = new Containers();
                string numContaino = jeuEnregistrements["NUMCONTAINER"].ToString();
                c._numContainer = Convert.ToInt16(numContaino);
                c._dateAchat = Convert.ToDateTime(jeuEnregistrements["DATEACHAT"].ToString());
                c._typeContainer = jeuEnregistrements["TYPECONTAINER"].ToString();
                c._dateLimite = Convert.ToDateTime(jeuEnregistrements["DATELIMITEPROCHINSP"].ToString());
                resultat.Add(c);
            }
            msc.Close();
            return resultat;
        }// Recupère tout les containers
        #endregion
    }
}
