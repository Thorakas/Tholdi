using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TholdiApplication.Modeles;
using TholdiApplication.Vues;
using System.DirectoryServices;

namespace TholdiApplication
{
    class Program
    {
        static void Main(string[] args)
        {

           

            List<Inspection> collectionInspection = Inspection.FetchAll();
            List<Declaration> collectionDeclaration = Declaration.FetchAll();
            List<Containers> collectionContainer = Containers.FetchAll();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPagePrincipal());

      
        }




    }
    }


