using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int resultado;
            int escolha;

            do
            {

                Console.WriteLine("Informe o numero da tabuada :");
                int nm1 = int.Parse(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {

                    resultado = nm1 * i;
                    Console.WriteLine("A tabuada do: " + nm1 + " x " + i + " e igual a:" + resultado);
                }

                int a = 0;

                /*
                do
                {
                    Console.WriteLine("O Primeiro numero e o :" + a);
                    a++;
                } while (a < 10);
               */

                Console.WriteLine("Digite 1 para continuar :");
                escolha = int.Parse(Console.ReadLine());
           
            } while (escolha == 1);
            Console.ReadKey();
        }
    }
}
