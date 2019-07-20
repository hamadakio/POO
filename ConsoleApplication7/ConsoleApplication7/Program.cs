using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int Media = 0, Soma = 0; ;
          
            

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Informe o "+(i+1)+" Numero");
                array[i] =int.Parse( Console.ReadLine());
                Soma = Soma + array[i];
            }

            Media = Soma / 10;
Console.WriteLine(Media);
            

            Console.ReadKey();

        }
    }
}
