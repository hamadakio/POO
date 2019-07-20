using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // chamada da funçao

            Console.WriteLine("A soma dos numeros e " + Soma(10,20));
            
            //chamada da funçao

            int iSoma = Soma(30, 15);
            Console.WriteLine("A Soma dos Numeros e" + iSoma);

            Console.ReadKey();


        }
        public static int Soma(int Numero1, int Numero2)
        {
            return (Numero1 + Numero2);
        }

    }
}
