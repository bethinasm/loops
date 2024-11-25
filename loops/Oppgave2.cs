using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Oppgave2
    {
        /* 
           Oppgave 2:
           Lag en foreach-løkke som går igjennom hver bokstav i en string og printer den til konsollen.
           Hint: en string kan brukes på samme måte som et array!
        */
        
        public void Run()
        {
            Console.WriteLine("Oppgave 2 - foreach-loop");
            Console.WriteLine("Skriv et ord:");
            string userInput = Console.ReadLine();

            foreach (char letter in userInput)
            {
                Console.WriteLine(letter);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
