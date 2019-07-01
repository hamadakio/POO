using System;

namespace Ex1_SemPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC; //lado triangulo X
            double yA, yB,yC;  //lado trinagulo y
            double p;          //perimetro
            double areaX, areaY; //area X e Y



            Console.WriteLine("Entre com as medidas do triangulo X :");
            xA = double.Parse(Console.ReadLine());
            xB = double.Parse(Console.ReadLine());
            xC = double.Parse(Console.ReadLine());

            Console.WriteLine("\nEntre com as medidas do triangulo Y :");
            yA = double.Parse(Console.ReadLine());
            yB = double.Parse(Console.ReadLine());
            yC = double.Parse(Console.ReadLine());

            p = (xA + xB + xC) / 2.0;
            areaX = Math.Sqrt(p*(p-xA)*(p-xB)*(p-xC));


            p = (yA + yB + yC) / 2.0;
            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("\nArea de X = " + areaX.ToString("F4"));
            Console.WriteLine("\nArea de Y = " + areaY.ToString("F4"));

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior Area triangulo X !");
            }
            else
            {
                Console.WriteLine("\nMaior Area triangulo Y !");
            }


            Console.ReadKey();
        }
    }
}


//formula de Heron utilizada pois nao se sabe a altura e apenas os lados 
// primeiro e necessario pegar o perimetro =>  p=(a+b+c)/2
// depois a area vai ser igual a raiz quadrada do perimetro vezes o perimetro menos os lados 
// a = raizquadrada(p*(p-a)*(p-b)*(p-c))