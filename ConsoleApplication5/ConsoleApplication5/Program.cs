using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string inome1;
            string inome2;

            Console.WriteLine("Digite o Primeiro Nome");
            inome1 = Console.ReadLine();
            Console.WriteLine("Digite o Ultimo Nome");
            inome2 = Console.ReadLine();

            string iNome = Nome(inome1, inome2);
            Console.WriteLine("Nome Completo : " + iNome);

            Console.ReadKey();
        }


        public static String Nome(string nome1,string nome2)
        {
            return (nome1 + " " + nome2);
        }
    }
}
