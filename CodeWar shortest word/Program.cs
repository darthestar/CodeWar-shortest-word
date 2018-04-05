using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWar_shortest_word
{
    class Program
    {

        static void FindShort(string s)
        //{
        //    int shortestWord = 100;

        //    string[] splitString = s.Split();
        //    foreach (string word in splitString)
        //    {
        //        if (word.Length < shortestWord)
        //        {
        //            shortestWord = word.Length;
        //        }
        //    }
        //    return shortestWord;

        //}
        {
            string [] arr = s.Split();
            int shortestWord = arr.Min(w => w.Length);
            Console.WriteLine("The shortest word is {0} characters long.", shortestWord);

        }

        static void Main(string[] args)
        {

            //int result = FindShort("bitcoin take over the world maybe who knows perhaps");
            //Console.WriteLine(result);
            FindShort("bitcoin take over the world maybe who knows perhaps");
                Console.ReadLine();
        }
    }
}
