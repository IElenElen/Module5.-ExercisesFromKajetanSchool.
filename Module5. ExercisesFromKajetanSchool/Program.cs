using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Module5._ExercisesFromKajetanSchool_
{
    public class Program
    {
        //Stała przed metodą Main!!!
        public const string FILE_NAME = @"C:\Users\Ilka\Desktop\.net\zakupy.csv"; //plik z listą zakupów

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, moduł 5.");
            Console.WriteLine();
            Console.WriteLine("Część: 5.5");
            Console.WriteLine();

            //Zapis dawny
            /*
             using (FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\zakupy.csv", FileMode.Open, FileAccess.Read))
            {

            } */
            //Nowoczesny zapis, ale długi
            /*
            using FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\zakupy.csv", FileMode.Open, FileAccess.Read);
            byte[] buf = new byte[1024];
            int c;
            while ((c = fs.Read(buf, 0, buf.Length)) > 0)
            {
                string text = Encoding.UTF8.GetString(buf, 0, c);
            } */

            //Łatwiejszy zapis
            /* ???
            var lines = File.ReadLines(@"C:\Users\Ilka\Desktop\.net\zakupy.csv"); //mi żadna tablica nie wyświetla się z automatu

            //var lines = File.ReadLines(FILE_NAME); //ten zapis podpowiada VS
            */

            //Zapisanie ścieżki 12:49
            string path = @"C:\Users\Ilka\Desktop\.net\zakupy.csv";
            /* using FileStream fs = File.OpenWrite(path);
            using StreamWriter sw = new StreamWriter(fs);
            //Użycie metody WriteLine, niestety ta metoda nadpisuje na już istniejącej linii,
            //... czyli potrzebna jak coś chcę zmienić = zmodyfikować
            /* sw.WriteLine("ser, 2"); */

            using StreamWriter sw = File.AppendText(path);
            sw.WriteLine("biały ser, 3"); //tu problem, bo zapisuje mi w ostatniej istniejącej linii
                                          //a nie w nowej pod spodem...
        }
    }
}

