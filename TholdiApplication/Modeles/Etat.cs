using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TholdiApplication.Modeles
{
    class Etat
    {
        // Champs de la classe Etat :
        private int _codeEtat;
        private string _libelleEtat;

        // Ascesseurs de la classe Etat :
        // Pas de mutateurs car les états sont définis !!

        public int CodeEtat
        {
            get { return _codeEtat; }
        }

        public string LibelleEtat
        {
            get { return _libelleEtat; }
        }

        // Constructeur de la classe Etat :
        public Etat(int codeEtat, string libelleEtat)
        {
            _codeEtat = codeEtat;
            _libelleEtat = libelleEtat;
        }

        // Méthodes de la classe Etat :
        #region Champs à portée classe contenant l'ensemble des requêtes d'accès aux données
        private static string _selectSql =
            "SELECT id , prenom, nom ,  telephone , email FROM contact";

        private static string _selectByIdSql =
            "SELECT id , prenom, nom ,  telephone , email FROM contact WHERE id = ?id ";

        private static string _updateSql =
            "UPDATE contact SET prenom = ?prenom, nom=?nom , telephone=?telephone, email=?email  WHERE id=?id ";

        private static string _insertSql =
            "INSERT INTO contact (prenom,nom,email,telephone) VALUES (?prenom,?nom,?email,?telephone)";

        private static string _deleteByIdSql =
            "DELETE FROM contact WHERE id = ?id";

        private static string _getLastInsertId =
            "SELECT id FROM contact WHERE prenom = ?prenom AND nom=?nom AND telephone=?telephone AND email=?email  ";
        #endregion

    }
}