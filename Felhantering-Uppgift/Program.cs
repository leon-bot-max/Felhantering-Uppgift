using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Felhantering_Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Console.Write("Mata in start ");
            string startInput = Console.ReadLine();
            Console.Write("Mata in stop ");
            string stopInput = Console.ReadLine();
            Console.Write("Mata in steg ");
            string stepInput = Console.ReadLine();

            if (int.TryParse(startInput, out int start) && int.TryParse(stopInput, out int stop) && int.TryParse(stepInput, out int step))
            {

                for (int i = start; i <= stop; i+= step)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine();



        }
    }
}
