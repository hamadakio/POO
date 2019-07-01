using System;
using System.Collections.Generic;
using System.Text;

namespace Ex2
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
    }


    class Funcionario : Pessoa
    {
        public double Salario;


        public Funcionario(string _Nome,int _Idade,double _Salario)
        {
            this.Nome = _Nome;
            this.Idade = _Idade;
            this.Salario = _Salario;
        }






    }
}
