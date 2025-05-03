using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace TholdiApplication.Modeles
{

    /// <summary>
    /// Classe de gestion de formulaire
    /// </summary>
    /// <remarks>La vérification est effectuée à partir d'opération sur les expressions régulières</remarks>
    public static class Formulaire
    {
        /// <summary>
        /// Vérifie le format de la chaine de caractère
        /// </summary>
        /// <param name="codePostal">Une chaine de caractère représentant une date</param>
        /// <returns>Vrai si la chaine représente un code postal, faux dans le cas contraire</returns>
        /// <remarks>Code postal utilisé en france métropolitaine</remarks>
        public static bool VerificationFormatCodePostal(string codePostal)
        {
            bool resultat = false;
            Regex formatCodePostal = new Regex(@"^\d{5}$");
            if (formatCodePostal.IsMatch(codePostal))
            {
                resultat = true;
            }
            return resultat;
        }

        /// <summary>
        /// Vérifie le format d'une date
        /// </summary>
        /// <param name="date">Une chaine de caractère représentant une date</param>
        /// <returns>Vrai si la chaine représente une date, faux dans le cas contraire</returns>
        /// <remarks>Format attentdu : jj[/-]mm[/-]aaaa</remarks>
        public static bool VerificationFormatDate(string date)
        {
            bool resultat = false;
            Regex formatDate = new Regex(@"^\d{1,2}[-/]\d{1,2}[-/]\d{4}$");
            if (formatDate.IsMatch(date))
            {
                resultat = true;
            }
            return resultat;
        }

        /// <summary>
        /// Vérifie le format d'un numéro de téléphone
        /// </summary>
        /// <remarks>Téléphone à 10 chiffres</remarks>
        /// <param name="telephone">Numéro de téléphone</param>
        /// <returns>Retourne "true" si le numéro de téléphone est composé de 10 chiffres, "false" dans le cas contraire</returns>
        static public bool VerificationTelephone(string telephone)
        {
            //Exemple d'instruction / expression simplifié
            return new Regex(@"^\d{10}$").IsMatch(telephone);
        }
    }

}
