using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace Module5._ExercisesFromKajetanSchool_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, moduł 5.");
            Console.WriteLine();

            Console.WriteLine("Część: 5.5");
            //zestaw kolorów i związanych z nimi rzeczami
            /* czerwone serce, niebieskie niebo, brązowa ziemia, żółte słońce */

            SortedList<string, string> colourAndThing = new SortedList<string, string>();

            //colourAndThing.Add("czerwona", "krew");

            //C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv

            /* starsza wersja zapisu
            using(FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv", FileMode.Append, FileAccess.ReadWrite))
            {

            } */

            //zapis rozbudowany
            /*using FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv", FileMode.Open, FileAccess.Read);
            string text = string.Empty;
            byte[] buf = new byte[1024];
            int c;
                while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                {
                    text = Encoding.UTF8.GetString(buf, 0, c);
                }
                Console.WriteLine($"{text}");*/

            //wersja krótsza //dlaczego tu nie tworzy mi się tablica?
            //var lines = File.ReadLines(@"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv");

            string path = @"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv";
            //using FileStream fs = File.OpenWrite(path);
            //using StreamWriter sw = new StreamWriter(fs);

            //sw.WriteLine("czerwona", "krew"); krew nie dopisała się
            ///ta metoda nadpisuje, jeśli zaś chcę dopisać to sposób poniższy
            using StreamWriter sw = File.AppendText(path);
            sw.WriteLine("czerwona", "krew"); //dopisuje się w linii ostatniej a nie w nowej linii
            //parsowanie???
        }
    }
}
