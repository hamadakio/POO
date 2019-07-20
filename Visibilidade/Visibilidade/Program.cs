using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visibilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato gatinho = new Gato();

            gatinho.nome = "Nina";
            gatinho.idade = 2;
            gatinho.peso = 8.4;
            gatinho.sexo = "feminino";

            Console.WriteLine("Nome "+gatinho.nome);
            Console.WriteLine("Idade "+gatinho.idade);
            Console.WriteLine("Peso "+gatinho.peso);
            Console.WriteLine("Sexo "+gatinho.sexo);

            gatinho.miar();

            Cachorro rex = new Cachorro();

            rex.PassarNome("Bidu");
            rex.Idade(2);
            rex.Peso(9.9);
            rex.Sexo("MASCULINO");
            

            Console.WriteLine("Nome do Cachorro "+rex.PegarNome());
            Console.WriteLine("Idade do Cachorro " + rex.PegarIdade());
            Console.WriteLine("Peso do Cachorro " + rex.PegarPeso());
            Console.WriteLine("Sexo do Cachorro " + rex.PegarSexo());

            rex.Latir();

            Animal bixo = new Animal();

            Macaco mac = new Macaco();
            mac.verPeso();
            Console.ReadKey();

        }
    }
}
