using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o " + (i+1) + " Numero");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < 10; i++)
            {

                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine((i + 1) + " é Par");
                }
                else
                {
                    Console.WriteLine((i + 1) + " é Impar");
                }
            }

            Console.ReadKey();

        }
    }
}
