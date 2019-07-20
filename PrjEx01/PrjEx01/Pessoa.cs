using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEx01
{
    class Pessoa
    {

        public string nome { get; set;}
        public int idade { get; set;}
        public string rg { get; set;}

        public string cpf { get; set;}
        public string nacionalidade { get; set;}
        public bool sexo { get; set;}

        public Pessoa (string _nome)
        {
         nome = _nome;
        }

        public Pessoa(string _nome,int _idade,string _rg,string _cpf,string _nacionalidade,bool _sexo)
        {
        nome = _nome;
        idade = _idade;
        rg = _rg;
        cpf = _cpf;
        nacionalidade = _nacionalidade;
        sexo = _sexo;
        
        }

    }
}
