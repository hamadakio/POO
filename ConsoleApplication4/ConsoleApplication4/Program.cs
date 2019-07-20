using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {

            int iEscolha;
         

            do
            {
                Console.WriteLine("Escolha uma opcao abaixo: \n");
                Console.WriteLine("1 - Adição ");
                Console.WriteLine("2 - Subtração ");
                Console.WriteLine("3 - Multiplicação ");
                Console.WriteLine("4 - Divisão ");
                Console.WriteLine("5 - Sair ");
                iEscolha = int.Parse(Console.ReadLine());
                if (iEscolha == 5)
                {
                    Console.WriteLine("Tchau.");
                    break;
                }
                Console.WriteLine("Digite o Primeiro Numero");
                int iNumero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Segundo Numero");
                int iNumero2 = int.Parse(Console.ReadLine());

                switch (iEscolha)
                {
                    case 1:
                        int iSoma = Soma(iNumero1, iNumero2);
                        Console.WriteLine(" A adição dos numeros e : " + iSoma);
                        break;
                    case 2:
                        int iSubtraçao = Subtraçao(iNumero1, iNumero2);
                        Console.WriteLine(" A subitração dos numeros e : " + iSubtraçao);
                        break;
                    case 3:
                        int iMultiplicaçao = Multiplicaçao(iNumero1, iNumero2);
                        Console.WriteLine(" A multiplicação dos numeros e : " + iMultiplicaçao);
                        break;
                    case 4:
                        int iDivisao = Divisao(iNumero1,iNumero2);
                        Console.WriteLine(" A divisão dos numeros e : " + iDivisao);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!" + iEscolha);
                        break;
                }

            } while (iEscolha != 5);

            Console.ReadKey();
        }
        public static int Soma(int Numero1, int Numero2)
        {
            return (Numero1 + Numero2);
        }

        public static int Subtraçao(int Numero1, int Numero2)
        {
            return (Numero1 - Numero2);
        }


        public static int Multiplicaçao(int Numero1, int Numero2)
        {
            return (Numero1 * Numero2);
        }

        public static int Divisao(int Numero1, int Numero2)
        {
            return (Numero1 / Numero2);
        }

    
    
    
    
    }
}
