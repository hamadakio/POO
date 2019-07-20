using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pontos = new int[10];
            string[] nomes = new string[10];
            int[] ranking = new int[2];
            string[] rankingnome = new string[2];


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe o Nome do Candidato ");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Informe a pontuacao do Cadidato ");
                pontos[i] = int.Parse(Console.ReadLine());
                if (pontos[i] < 0 || pontos[i] > 100)
                {
                    Console.WriteLine("Pontuacao Invalida");
                    Console.WriteLine("Informe a pontuacao do Cadidato ");
                    pontos[i] = int.Parse(Console.ReadLine());
                }

                if (pontos[i]>=ranking[0] && pontos[i] <ranking[1])
                {
                      ranking[0]=pontos [i];
                      rankingnome[0] = nomes[i];
                }
                else if (pontos[i]>ranking[2] && pontos[i]<ranking[0])
                {
                    ranking[1] = pontos[i];
                    rankingnome[1] = nomes[i];
                }
                else if (pontos[i] <ranking[1] && pontos[i] < ranking[0])
                {
                   ranking[2] = pontos[i];
                   rankingnome[2] = nomes[i];
                }

                
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("O "+  (i+1) + " colocado e :" + rankingnome[i]);
                Console.WriteLine("A Pontuacao foi de :"+ ranking[i]);

            }

            Console.ReadKey();

        }
    }
}
