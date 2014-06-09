using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NumberToText;

namespace NumberToCharecters
{
    class Program
    {
        static void Main(string[] args)
        {
            string choi=" ";
            while (choi != "E")
            {
                ToText.DigitsToText();
                Console.WriteLine("\n\nPress E to End or C To Continue");
                choi = Console.ReadLine();
                
                if (choi == "c")
                    choi = "C";
                if (choi == "e")
                    choi = "E";

                while (choi != "C" && choi != "E")
                {
                    Console.WriteLine("Invalid Input Re-Enter Your Choice");
                    choi = Console.ReadLine();
                    if (choi == "c")
                        choi = "C";
                    if (choi == "e")
                        choi = "E";
                }
                 


            }
        }
    }
}
