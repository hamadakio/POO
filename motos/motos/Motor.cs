using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motos
{
    class Motor
    {
        public bool Ligado { get; private set; }

        public void Ligar()
        {

            bool temgasolina = TemGasolina();

            if (temgasolina)
            {
                Ligado = true;
            }
        
        }

        public override string ToString()
        {
            if (Ligado)
                return "O motor esta ligado";
            else
                return "O motor esta desligado";
        }

        private bool TemGasolina()
        {
            return true;
        }


    }
}
