using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euromoney
{
    class Program
    {

        //KP : Class-Level static Variables
        static string bannedWord1 = "swine";
        static string bannedWord2 = "bad";
        static string bannedWord3 = "nasty";
        static string bannedWord4 = "horrible";

        static void Main(string[] args)
        {
            //KP : Made class-level static variables
            //string bannedWord1 = "swine";
            //string bannedWord2 = "bad";
            //string bannedWord3 = "nasty";
            //string bannedWord4 = "horrible";

            string content =
                "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";

            int badWords = 0;
            if (content.Contains(bannedWord1))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord2))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord3))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord4))
            {
                badWords = badWords + 1;
            }

            Console.WriteLine("Scanned the text:");
            Console.WriteLine(content);
            Console.WriteLine("Total Number of negative words: " + badWords);

            //KP : User Story 3 : Replace Negative Words with Morphed Words
            string filteredContent = filterNegativeWords(content);
            Console.WriteLine("Filtered Content : " + filteredContent);

            Console.WriteLine("Press ANY key to exit.");
            Console.ReadKey();
    
        }


        //KP : User Story 1 : Get Number of Negative Words.
        static int getNumOfNegativeWords(string content)
        {
            int badWords = 0;

            if (content.Contains(bannedWord1))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord2))
            {
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord3))
            {               
                badWords = badWords + 1;
            }
            if (content.Contains(bannedWord4))
            {
                badWords = badWords + 1;
            }

            return badWords;
        }

        //KP : User Story 3 : Filter Negative Words.
        static string filterNegativeWords(string content)
        {           
            string output = "";
            int badWords = 0;

            //KP : Morphed Output Variables
            string morphedWord1 = "s###e";
            string morphedWord2 = "b#d";
            string morphedWord3 = "n###y";
            string morphedWord4 = "h######e";

            if (content.Contains(bannedWord1))
            {
                badWords = badWords + 1;
                content = content.Replace(bannedWord1, morphedWord1);
            }
            if (content.Contains(bannedWord2))
            {
                badWords = badWords + 1;
                content = content.Replace(bannedWord2, morphedWord2);
            }
            if (content.Contains(bannedWord3))
            {
                badWords = badWords + 1;
                content = content.Replace(bannedWord3, morphedWord3);
            }
            if (content.Contains(bannedWord4))
            {
                badWords = badWords + 1;
                content = content.Replace(bannedWord4, morphedWord4);
            }

            return content;
        }

    }
}
