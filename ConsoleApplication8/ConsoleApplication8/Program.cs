using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {

            int[]array = new int [10];
            int Maior=0;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Informe o " + (i + 1) + " Numero");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] > Maior)
                {
                    Maior=array[i];
                }
                

            }

            Console.WriteLine(Maior);
            Console.ReadKey();

            
        }
    }
}
