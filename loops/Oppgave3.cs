using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    internal class Oppgave3
    {
        /*
            Oppgave 3:
            Lag en while-løkke som printer ut 
            "Runde nummer:" + et tall som øker med 1 per runde, 
            så lenge rundetelleren er mindre enn 10
           
            Eks:
            Runde nr 1
            Runde nr 2
            Runde nr 3
         */

        public void Run()
        {
            Console.WriteLine("Oppgave 3 - while-loop");
            bool printMore = true;
            int i = 1;
            while (printMore)
            {
                if (i > 9)
                {
                    printMore = false;
                }
                Console.WriteLine("Runde nr: " + i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
