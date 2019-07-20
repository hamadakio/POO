using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEx01
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nome;
            int idade;

            Console.WriteLine("Ola Alunos da Uniso");
            Console.WriteLine("Digite o Nome Do Aluno");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a Idade Do Aluno");
            idade = int.Parse(Console.ReadLine());



            Aluno cAluno = new Aluno(Nome,idade);

            Console.WriteLine("Aluno Nome = {0} Idade = {1}" , cAluno.Nome ,cAluno.Idade);

            string nome2;
            int Idade2;
            string rg;
            string cpf;
            string nacionalidade;
            int matricula;
            string profissao;
            string setor;


            Console.WriteLine("Digite o Nome Do Funcionario");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite a Idade Do Funcionario");
            Idade2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Rg Do Funcionario");
            rg = Console.ReadLine();
            Console.WriteLine("Digite o Cpf do Funcionario");
            cpf = Console.ReadLine();
            Console.WriteLine("Digite a Nacionalidade do Funcionario");
            nacionalidade = Console.ReadLine();
            Console.WriteLine("Digite a Matricula");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Profissao do Funcionario");
            profissao = Console.ReadLine();
            Console.WriteLine("Digite o Setor do Funcionario");
            setor = Console.ReadLine();


            Funcionario cFuncionario = new Funcionario( nome2 , idade , rg ,cpf ,
                nacionalidade,true,matricula,profissao,setor);

            Console.WriteLine("Nome do Funcionario " + cFuncionario.nome);
            Console.WriteLine("Idade Funcionario " + cFuncionario.idade);
            Console.WriteLine("Rg Funcionario " + cFuncionario.rg);
            Console.WriteLine("CPF Funcionario " + cFuncionario.cpf);
            Console.WriteLine("Nacionalidade Funcionario "+ cFuncionario.nacionalidade);

            string cSexo = cFuncionario.sexo == true ? "Masculino" : "Feminino";
            Console.WriteLine("Sexo Funcionario "+cSexo);
            Console.WriteLine("Matricula Funcionario " + cFuncionario.matricula);
            Console.WriteLine("Profissao Funcionario " + cFuncionario.profissao);
            Console.WriteLine("Setor Funcionario " + cFuncionario.setor);




            Console.ReadKey();

        }
    }
}
