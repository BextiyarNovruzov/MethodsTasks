using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {   //2.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın
            //məs .("Hello World --> "H" "W" )
            Console.WriteLine("Cumleni daxil et ve enter press et: ");
            string sentence = Console.ReadLine();

            FirstLetters(sentence);
        }
        static void FirstLetters(string sentence)
        {
            Regex regex = new Regex(@"\b\w");

            MatchCollection matches = regex.Matches(sentence);

            Console.WriteLine("Sozlerin bas herfleri:");
            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
            Console.WriteLine();


        }
    }
}