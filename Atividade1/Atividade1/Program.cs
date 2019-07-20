using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Nomes = new string[10];
            int[]    Notas = new int[10];
            string[] NomesRanking = new string[10];
            int aux = 0;


            for (int h = 0; h < 10; h++)
            {
                
                Console.Write("Digite o Nome do Candidato :");
                Nomes[h] = Console.ReadLine();
                Console.WriteLine("Digite a Pontuaçao do Candidato :");
                Notas[h] = int.Parse(Console.ReadLine());
                if (Notas[h] < 0 || Notas[h] > 100)
                {
                    Console.WriteLine("Nota Invalida !");
                    Console.WriteLine("Digite a Pontuaçao do Candidato :");
                    Notas[h] = int.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < Notas.Length; i++)
            {
                for (int j = 0; j < Notas.Length; j++)
                {
                    if (Notas[i] > Notas[j])
                    {
                        aux = Notas[i];
                        Notas[i] = Notas[j];
                        Notas[j] = aux;

                        NomesRanking[i] = Nomes[i];
                    }

                }
            }
            


            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Candidato :" + NomesRanking[k]);
                Console.WriteLine("Nota : " + Notas[k]);
              
            }


            Console.ReadKey();

        }
    }
}
