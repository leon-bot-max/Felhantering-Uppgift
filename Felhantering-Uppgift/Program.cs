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
            bool done = false;
            while (!done)
            {
                try
                {
                    Console.Clear();

                    Console.Write("Mata in start ");
                    int start = int.Parse(Console.ReadLine());
                    Console.Write("Mata in stop ");
                    int stop = int.Parse(Console.ReadLine());
                    Console.Write("Mata in steg ");
                    int step = int.Parse(Console.ReadLine());

                    for (int i = start; i <= stop; i += step)
                    {
                        done = true;
                        Console.Write(i + " ");
                    }
                }
                catch (Exception e)
                {

                }
            }
            Console.ReadLine();
        }
    }
}
