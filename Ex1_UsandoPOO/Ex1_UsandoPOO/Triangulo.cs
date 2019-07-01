using System;

namespace Ex1_UsandoPOO
{
    class Triangulo
    {
        //Variaveis
        public double A;
        public double B;
        public double C;

        public double CalculaArea()
        {
            double p;
            double area;

            p = (A + B + C) / 2.0;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return area;
        }


    }
}
