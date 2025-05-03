using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TholdiApplication.Modeles
{
    class Motif
    {
     
     
            private string _codeMotif;

            public string CodeMotif
            {
                get { return _codeMotif; }
                set { _codeMotif = value; }
            }
            private string _libelleMotif;

            public string LibelleMotif
            {
                get { return _libelleMotif; }
                set { _libelleMotif = value; }
            }


            public Motif(string codeMotif, string LibelleMotif)
            {
                _codeMotif = codeMotif;
                _libelleMotif = LibelleMotif;
            }
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

