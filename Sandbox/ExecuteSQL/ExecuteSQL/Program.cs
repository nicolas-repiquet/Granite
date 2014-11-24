using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace ExecuteSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = null;

            if (!args.Any())
            {
                Console.WriteLine("Veuillez renseignez un chemin de fichier !");
                file = Console.ReadLine();
            }
            else
            {
                file = args[0];
            }

            // Or specify a specific name in the current dir
            var ini = new IniFile("Settings.ini");

            string sqlConnectionString = ini.Read("connectionString");

            string script = File.ReadAllText(file);

            script = script.Replace("#SITE_CODE#", "CHU-LYON");

            try
            {
                SqlConnection conn = new SqlConnection(sqlConnectionString);

                conn.Open();
                Console.WriteLine("Connection : " + conn.State);

                using (var command = new SqlCommand(script, conn))
                {
                    var result = command.ExecuteNonQuery();
                    Console.WriteLine("Nombre de lignes affectées : " + result);
                }
                conn.Close();
                Console.WriteLine("Connection : " + conn.State);
            }
            catch (Exception e)
            {
                Console.WriteLine("Une erreur est survenue : " + e.Message + @"\n " + e.StackTrace);
            }

            Console.ReadKey();

        }
    }
}
