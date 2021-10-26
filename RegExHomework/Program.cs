using System;
using System.Text.RegularExpressions;

namespace RegExHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneMatching();

            for (int i=0; i < 3; i++)
            {
                WordCheck();
            }
        }
        static void PhoneMatching()
        {
            string[] inputPhone = { "+35 392-022-194", "+958 28492-503", "123-456-7890", "+36 665-999-235" };

            Regex rgx = new Regex(("(^[+]\\d{2}\\s\\d{3}[-]\\d{3}[-]\\d{3}$)"));

            foreach (string inputPhoneNr in inputPhone)
            {
                if (rgx.IsMatch(inputPhoneNr))
                {
                    Console.WriteLine($"{inputPhoneNr} - MATCH phone number format +XX YYY-YYY-YYY");
                }
                else
                {
                    Console.WriteLine($"{inputPhoneNr} - NO MATCH phone number format +XX YYY-YYY-YYY");
                }
            }
            Console.ReadLine();
        }
        static void WordCheck()
            {
            Console.WriteLine("Please input your sentence:");
            Console.WriteLine();
            string inputSentence = Console.ReadLine();
            EveryWordInTheString(inputSentence);
            Console.WriteLine(EveryWordInTheString(inputSentence));
            Console.ReadLine();
                                 
           static string EveryWordInTheString(string inputSentence)
            { 
            Regex rgx = new Regex(("(^|\\s)[a-z0-9].*?($|\\s)"));
                if (rgx.IsMatch(inputSentence))
                {
                    return $"NOT all word begin with capital letters";
                }
                else
                {
                    return $"ALL words begin with capital letters";
                }
            }
        }
    }
}
