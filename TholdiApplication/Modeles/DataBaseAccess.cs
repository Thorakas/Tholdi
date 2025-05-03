
using MySql.Data.MySqlClient;

namespace TholdiApplication.Modeles
{
    static class DataBaseAccess
    {
        private static string _connexion = "Database=tholdippe3;Data Source=localhost;User Id=root;Password=;Convert Zero Datetime=True;Allow Zero Datetime=True";

        public static MySqlConnection Connexion
        {
            get
            {
                return new MySqlConnection(_connexion);
            }


        }

        public static MySqlParameter CodeParam(string paramName, object value)
        {
            MySqlCommand commandSql = new MySqlCommand();
            MySqlParameter parametre = commandSql.CreateParameter();
            parametre.ParameterName = paramName;
            parametre.Value = value;
            return parametre;
        }
    }
}

//Avec Abstraction -> Diminue le COUPLAGE 

//public static IDbConnection Connexion { get; set; }

//public static IDbDataParameter CodeParam(string paramName, object value)
//{
//    IDbCommand commandSql = Connexion.CreateCommand();
//    IDbDataParameter parametre = commandSql.CreateParameter();
//    parametre.ParameterName = paramName;
//    parametre.Value = value;
//    return parametre;
//}