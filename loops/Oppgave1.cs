using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Oppgave1
    {
        /* 
           Oppgave 1: 
           Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger
        */

        public void Run()
        {
            Console.WriteLine("Oppgave 1 - for-loop");
            Console.ReadKey();

            string text = "Terje er kul";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{text}");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
