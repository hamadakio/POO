using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int Menor = 0;

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Informe o " + (i + 1) + " Numero");
                array[i] = int.Parse(Console.ReadLine());
                if (array[i] < Menor)
                {
                    Menor = array[i];
                }
                else if (Menor>array[i])
                {
                    Menor = array[i];
                }

            }

            Console.WriteLine(Menor);
            Console.ReadKey();
        }
    }
}
