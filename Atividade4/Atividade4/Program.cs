using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra;
            string tentativaPalavra;
            char letra;
            int tentativa=0;

            Console.WriteLine("Digite uma Palavra");
            palavra = Console.ReadLine();

            char[] Letras = palavra.ToCharArray();
            Console.Clear();
            do
            {
                Console.WriteLine("Digite uma Letra :");
                letra = Convert.ToChar(Console.ReadLine());

                for (int i = 0; i < palavra.Length; i++)
                {
                    if (letra == palavra[i])
                    {
                        Console.WriteLine("=====> " + palavra[i]);
                    }
                    else if (letra != palavra[i])
                    {
                        Console.WriteLine("=====>");
                    }
                }
                tentativa++;

            } while (tentativa < 3);

            Console.WriteLine("\nQual e a Palavra ? ");
            tentativaPalavra = Console.ReadLine();

            if (tentativaPalavra == palavra)
            {
                Console.WriteLine("Voce Ganhou !!!");
            }
            else
            {
                Console.WriteLine("Voce Perdeu ");
            }

            Console.ReadKey();
        }
    }
}
