using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar
            // qalmayacaq hala gətirən metod.Misal olaraq, name = " Yusif    Osmanov   " deyə bir variable- mız
            // varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "YusifOsmanov" olmalıdır.

            Console.WriteLine("sentence daxil et ve enter press et: ");
            string sentence = Console.ReadLine();
            removespaces(sentence);

        }
        static void removespaces(string sentence) 
        {

            string result = "";
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    result += sentence[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}