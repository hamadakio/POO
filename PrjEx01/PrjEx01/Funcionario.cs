using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEx01
{
    class Funcionario :Pessoa
    {

        public int matricula { get; set; }
        public string profissao { get; set; }
        public string setor { get; set; }

        public Funcionario(string _nome, int _idade, string _rg, string _cpf, string _nacionalidade, 
            bool _sexo, int _matricula, string _profissao, string _setor)
            :base ( _nome,  _idade,  _rg,  _cpf,  _nacionalidade,  _sexo)
        {
            matricula = _matricula;
            profissao = _profissao;
            setor = _setor;
        
        }


    }
}
