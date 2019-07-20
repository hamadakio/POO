using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {

            int[]array = new int[5];

            array[0]=10;
            array[1]=20;
            array[2]=30;
            array[3]=40;
            array[4]=50;

            for (int i=0;i<5;i++)
            {
              Console.WriteLine("O Elemento"+i+"e igual :"+array[i]);
            }

            Console.ReadKey();
        }
    }
}
