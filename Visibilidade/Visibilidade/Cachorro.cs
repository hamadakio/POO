using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visibilidade
{
    class Cachorro
    {


        private string nome { get; set; }
        private int idade { get; set; }
        private double peso { get; set; }
        private string sexo { get; set; }

        public void PassarNome(string _nome)
        {
            this.nome = _nome;        
        }

        public void Idade(int _idade)
        {
            this.idade = _idade;
        }

        public void Peso(double _peso)
        {
            this.peso = _peso;
        }

        public void Sexo(string _sexo)
        {
            this.sexo = _sexo;
        }

        public string PegarNome()
        {
            return nome;
        }

        public int PegarIdade()
        {
            return idade;
        }

        public double PegarPeso()
        {
            return peso;
        }

        public string PegarSexo()
        {
            return sexo;
        }

        public void Latir()
        {
            Console.WriteLine("Au Au");
        }
    }
}
