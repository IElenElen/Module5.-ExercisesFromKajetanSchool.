using System.ComponentModel;
using System.Text;

namespace Module5._ExercisesFromKajetanSchool_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, moduł 5.");
            Console.WriteLine();

            //zestaw kolorów i związanych z nimi rzeczami
            /* czerwone serce, niebieskie niebo, brązowa ziemia, żółte słońce */

            SortedList<string, string> colourAndThing = new SortedList<string, string>();

            /*colourAndThing.Add("czerwone", "serce");
            colourAndThing.Add("niebieskie", "niebo");
            colourAndThing.Add("brązowa", "ziemia");
            colourAndThing.Add("żółte", "słońce");*/
            //C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv

            /* starsza wersja zapisu
            using(FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv", FileMode.Append, FileAccess.ReadWrite))
            {

            } */

            //dlaczego nie otwiera mi się plik csv? Kajtkowi otwiera się...
            using FileStream fs = File.Open(@"C:\Users\Ilka\Desktop\.net\KoloroweRzeczy.csv", FileMode.Open, FileAccess.Read);
            string text = string.Empty;
            byte[] buf = new byte[1024];
            int c;
                while ((c = fs.Read(buf, 0, buf.Length)) > 0)
                {
                    text = Encoding.UTF8.GetString(buf, 0, c);
                }
                Console.WriteLine($"{text}");
        }
    }
}
