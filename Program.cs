using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euromoney
{
    class Program
    {

        //KP : Class-Level static Variables : Set of Negative Words
        static string bannedWord1 = "swine";
        static string bannedWord2 = "bad";
        static string bannedWord3 = "nasty";
        static string bannedWord4 = "horrible";

        //KP : Original Content String
        static string content =
                "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";

        //KP : Output String with Morphoed Negative Words
        static string filteredContent = "";

        static void Main(string[] args)
        {
            //KP : Made class-level static variables
            //string bannedWord1 = "swine";
            //string bannedWord2 = "bad";
            //string bannedWord3 = "nasty";
            //string bannedWord4 = "horrible";

            //string content =
            //    "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";

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

            //KP : User Story 4 : Read the Console Input to read the disable flag
            Console.WriteLine("Press '1' to disable the negative word filering : ");
            int disable = Console.Read();
            string displayContent = disableNegativeWordFiltering(disable);
            Console.WriteLine("Content displayed after disable : " + displayContent);

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
            string output = content;
            int badWords = 0;

            //KP : Morphed Output Variables
            string morphedWord1 = "s###e";
            string morphedWord2 = "b#d";
            string morphedWord3 = "n###y";
            string morphedWord4 = "h######e";


            filteredContent = content;
            if (filteredContent.Contains(bannedWord1))
            {
                badWords = badWords + 1;
                filteredContent = filteredContent.Replace(bannedWord1, morphedWord1);
            }
            if (filteredContent.Contains(bannedWord2))
            {
                badWords = badWords + 1;
                filteredContent = filteredContent.Replace(bannedWord2, morphedWord2);
            }
            if (filteredContent.Contains(bannedWord3))
            {
                badWords = badWords + 1;
                filteredContent = filteredContent.Replace(bannedWord3, morphedWord3);
            }
            if (filteredContent.Contains(bannedWord4))
            {
                badWords = badWords + 1;
                filteredContent = filteredContent.Replace(bannedWord4, morphedWord4);
            }

            return filteredContent;
        }

        //KP : User Story 4 : Disable Negative Word Filtering
        static string disableNegativeWordFiltering(int disable)
        {
            //ASCII Table Value for 'Character 1' is '49' = Hence Check is on 49
            if (disable == 49)
                return content;
            else
                return filteredContent;
        }

    }
}
