using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             
            // REVERSE A STRING MANUALLY AND USING IN-BUILT FUNCTION
            
            string name = "pragati";
            name.Reverse();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
            

            // INITIALIZING A DICTIONARY AND PRINTING ALL ELEMENTS BY ITERATING

            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {1 , "abc" },
                {2 , "xyz" },
                {3 , "HP" }
            };
            for(int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine($"{dict.ElementAt(i).Key} : {dict.ElementAt(i).Value}");
            }

            Console.ReadLine();
        }
    }
}
