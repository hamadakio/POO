using System;

namespace Ex1_UsandoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("Entre com as medidas do triangulo X :");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com as medidas do triangulo Y :");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine("\nArea de X = " + x.CalculaArea().ToString("F4"));
            Console.WriteLine("\nArea de Y = " + y.CalculaArea().ToString("F4"));

            Console.WriteLine(ComparaArea(x.CalculaArea(), y.CalculaArea()));

            Console.ReadKey();

        }


        public static string ComparaArea(double v1, double v2)
        {
            string output = null;

            if (v1 > v2)
            {
                output = "\nMaior Area triangulo X !";
            }
            else if (v2 > v1)
            {
                output = "\nMaior Area triangulo Y !";
            }
            else if (v1 == v2)
            {
                output = "\nOs Triangulos tem a mesma AREA !";
            }

            return output;
        }


    }
}
