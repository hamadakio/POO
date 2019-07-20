using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = new string[10];
            double[] array2 = new double[10];
            double[] Aumento = new double[10] ;
            double[] Porcentagem = new double[10] ;


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Informe o " + (i + 1) + " Nome de Funcionario");
                array[i] = Console.ReadLine();
                Console.WriteLine("Infome o salario do Funcinario " +(i + 1));
                array2[i] = double.Parse(Console.ReadLine());

                if (array2[i] >= 2000)
                {
                    Porcentagem [i]= array2[i]*0.10;
                    Aumento[i] = array2[i] + Porcentagem[i];
                }
                else if (array2[i] >= 2000.01 && array2[i] <= 5000)
                {
                    Porcentagem[i] = array2[i]*0.08;
                    Aumento[i] = array2[i] + Porcentagem[i];
                }
                else if (array2[i] >= 5000.01 && array2[i] <= 10000)
                {
                    Porcentagem[i] = array2[i]*0.05;
                    Aumento[i] = array2[i] + Porcentagem[i];
                }
                else if (array2[i]>=10000.01)
                {
                    Porcentagem[i] = array2[i]*0.03;
                    Aumento[i] = array2[i] + Porcentagem[i];
                }
           
            
            }


            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Nome: " + array[i]+
                    "\nSalario Atual: " +array2[i] +
                    "\nSalario Final: " + Aumento[i]+
                    "\n Porcentagem" + Porcentagem[i]);
            
            }


            Console.ReadKey();






        }
    }
}
