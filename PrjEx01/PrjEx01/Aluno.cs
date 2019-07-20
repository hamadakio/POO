using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEx01
{
    class Aluno
    {

        public string Nome {get; set;}
        public int Idade {get;set;}       
  
        public Aluno (string _nome , int _idade)
        {
          Nome = _nome;
          Idade = _idade;
        }


    }
}
