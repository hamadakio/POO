using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vNome = new string[10];
            double[] vNota = new double[10];
            double media = 0;
            int cont = 0;

            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("Digite o Nome do Aluno :");
                vNome[i] = Console.ReadLine();
                Console.WriteLine("Digite a Nota do Candidato :");
                vNota[i] = Double.Parse(Console.ReadLine());

                media = media + vNota[i];
            }

            media = media / 10;
            Console.WriteLine(media);
            for (int i = 0; i < 10; i++)
            {
                if (vNota[i] < media)
                {
                    Console.WriteLine("Aluno " + vNome[i] + " Reprovado " + "Nota " + vNota[i]);
                    cont++;
                }


            }

            Console.WriteLine("Numero de Alunos Reprovados :" + cont);
            Console.ReadKey();


        }

    }
}
