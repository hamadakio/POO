using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visibilidade
{
    class Macaco:Animal
    {
        public void verPeso()
        {
            this.idade = 2;
            this.peso = 10;
            Console.WriteLine("Peso {0}",this.peso);
            Console.WriteLine("Idade {0}",this.peso);
    
        }

    }
}
