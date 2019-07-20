using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iEscolha;
            //Menu
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
                        Console.WriteLine(" A adição dos numeros e : " + (iNumero1 + iNumero2));
                        break;
                    case 2:
                        Console.WriteLine(" A subitração dos numeros e : " + (iNumero1 - iNumero2));
                        break;
                    case 3:
                        Console.WriteLine(" A multiplicação dos numeros e : " + (iNumero1 * iNumero2));
                        break;
                    case 4:
                        Console.WriteLine(" A divisão dos numeros e : " + (iNumero1 / iNumero2));
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!!!" + iEscolha);
                        break;
                }
                // Dá uma pausa para permitir que o usuário veja o resultado
                Console.Write("Pressione ENTER para continuar...");
                Console.ReadLine();
                Console.WriteLine();
                Console.Clear();
            } while (iEscolha != 5);
            Console.ReadKey();
        }


    }
}

