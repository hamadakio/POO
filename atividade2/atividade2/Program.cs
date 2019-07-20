using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o "+(i+1) +" Numero:");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine("O Numero " + (i + 1) + " e Par ");
                }
                else
                {
                    Console.WriteLine("O Numero " + (i + 1) + " e Impar ");
                }


           }

            Console.ReadKey();
        }
    }
}
