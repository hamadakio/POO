using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motos
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();

            Console.WriteLine(motor.ToString());

            motor.Ligar();

            Console.WriteLine(motor.ToString());

           // motor.Ligado = true;

            Console.ReadKey();

        }
    }
}
