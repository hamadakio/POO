using System;
using System.Collections.Generic;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            string nome = null;
            int idade = 0;
            double salario = 0.0;
            double salMedio = 0;


            bool ExitMenu = false;


            while (!ExitMenu)
            {
                Console.Clear();
                int Menu = 0;

                Console.WriteLine("Digite a Opcao desejada : " +
                                   "\n1 - Cadastrar Funcionario(a)" +
                                   "\n2 - Media Salarial" +
                                   "\n3 - Funcionario(a) mais Velho(a)" +
                                   "\n4 - Sair");
                Menu = int.Parse(Console.ReadLine());


                switch (Menu)
                {
                    case 1:

                        Console.WriteLine("Digite o nome do(a) Funcionaro(a) :");
                        nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade do(a) Funcionaro(a) :");
                        idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o Salario do(a) Funcionaro(a) :");
                        salario = double.Parse(Console.ReadLine());

                        funcionarios.Add(new Funcionario(nome, idade, salario));

                        break;

                    case 2:

                        foreach (var item in funcionarios)
                        {
                            salMedio += item.Salario;
                        }

                        salMedio = salMedio / funcionarios.Count;

                        Console.WriteLine("O Salario medio dos " + funcionarios.Count.ToString() + " Funcionaros(as) e de R$ " + salMedio.ToString());
                        Console.ReadKey();

                        break;

                    case 3:

                        Console.WriteLine(MaisVelhx(funcionarios));
                        Console.ReadKey();

                        break;

                    case 4:

                        ExitMenu = true;

                        break;

                }

            }

        }


        public static string MaisVelhx(List<Funcionario> func)
        {
            string nomeFunc = "", saida = "";
            int aux = 0;

            foreach (var item in func)
            {
                if (item.Idade > aux)
                {
                    nomeFunc = item.Nome;
                    aux = item.Idade;
                }
            }

            saida = "O(A) Funcionario(a) mais velho(a) :" +
                     "\n Nome:" + nomeFunc.ToString() +
                     "\n Idade:" + aux.ToString();

            return saida;
        }

    }


}
