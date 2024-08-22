using System.IO.Compression;
using System.Text;

namespace SYSTEMFICHIER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Votre nom");
             string? nom = Console.ReadLine();

             Console.WriteLine("Votre prenom");
             string? prenom = Console.ReadLine();

             string resultat = $"{prenom} {nom}";*/
            //Ecriture dans un fichier
            //using (var fs = new FileStream(@"C:\Users\abots\source\repos\SYSTEMFICHIER\Monfichier.txt",FileMode.OpenOrCreate))
            //{
            //    var bytes=Encoding.UTF8.GetBytes(resultat);
            //    fs.Write(bytes, 0, bytes.Length);
            //}

            //Lecture dans un fichier
            //using (var fs=new FileStream(@"C:\Users\abots\source\repos\SYSTEMFICHIER\Monfichier.txt", FileMode.Open))
            //{
            //    byte[] buffer = new byte[128];
            //    int nbcarac =fs.Read(buffer, 0, buffer.Length);
            //    Console.WriteLine(Encoding.UTF8.GetString(buffer[0..nbcarac]));
            //}
            //Ecriture et lecture d'un fichier
            /* using(var fs=new FileStream(@"C:\Users\abots\source\repos\SYSTEMFICHIER\Monfichier2.txt", FileMode.OpenOrCreate))
             {
                 var sw = new StreamWriter(fs);
                 sw.WriteLine(resultat);
                 fs.Seek(0, SeekOrigin.Begin);

                 var sr = new StreamReader(fs);
                 Console.WriteLine(sr.ReadToEnd());
                 sw.Close();
                 sr.Close();
             }*/
            //Compression
            //using (var fs = new FileStream(@"C:\Users\abots\source\repos\SYSTEMFICHIER\logs.bin", FileMode.OpenOrCreate))
            //{
            //    using(var gz = new GZipStream(fs, CompressionLevel.Optimal))
            //    {
            //        gz.Write(Encoding.UTF8.GetBytes($"{resultat} s'est connecter a {DateTime.Now:dd/MM/yyy HH:mm}"));
            //    }
            //}
            //Creation de repertoire et fichier
            /*const string DOSSIER = @"C:\Users\abots\source\repos\SYSTEMFICHIER\data";
            const string FICHIER = DOSSIER + @"\monfichier.txt";

            if (!Directory.Exists(DOSSIER))
            {
                Directory.CreateDirectory(DOSSIER);
            }
            else
            {
                Console.WriteLine("Le repertoire existe deja");
            }

            if (File.Exists(FICHIER))
            {
                File.Delete(FICHIER);
            }

            File.WriteAllText(FICHIER, resultat);
            Console.WriteLine(File.ReadAllText(FICHIER));*/

            const string FICHIER = @"C:\Users\abots\source\repos\SYSTEMFICHIER\monfichierzip.zip";
            const string DOSSIER = @"C:\Users\abots\source\repos\SYSTEMFICHIER\data";

            if (File.Exists(FICHIER))
            {
                File.Delete(FICHIER);
            }
            using(var zip = ZipFile.Open(FICHIER,ZipArchiveMode.Create))
            {
                foreach (var entry in Directory.GetFiles(DOSSIER))
                {
                    zip.CreateEntryFromFile(entry, Path.GetFileName(FICHIER));
                }
                    
            }

        }
    }
}
