using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToCharecters
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlaceValue, Numb;

            string[] Numbers = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Elevan", "Twelve", "Thirteen",
                                   "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eightteen", "Nineteen" };
            
            string[] Tens = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };

            Console.WriteLine("Enter a Number Between 1 to 9999");
            Numb = int.Parse(Console.ReadLine());

            //for Thousand Place Value
            PlaceValue = Numb / 1000;
            if(PlaceValue>=1 && PlaceValue<=9)
            {
                Console.Write(Numbers[PlaceValue - 1] + " Thousand ");
            }

            //for Hundred Place Value
            Numb=Numb%1000;
            PlaceValue = Numb / 100;
            if(PlaceValue>=1 && PlaceValue<=9)
            {
                Console.Write(Numbers[PlaceValue - 1] + " Hundreds ");
            }

            //for place of two decimal
            Numb=Numb%100;
            if (Numb>0)
                Console.Write(" And ");
            
            if(Numb<20 && Numb>0)
                Console.WriteLine(Numbers[Numb-1]);
            else
            {
                PlaceValue = Numb / 10;
                if(PlaceValue>=2 && PlaceValue<=9)
                {
                    Console.Write(Tens[PlaceValue - 2]);
                }
                Numb=Numb % 10;
                if (Numb > 0 && Numb <= 9)
                {
                    Console.WriteLine(Numbers[Numb - 1]);
                }

            }
            Console.ReadLine();
        }
    }
}
