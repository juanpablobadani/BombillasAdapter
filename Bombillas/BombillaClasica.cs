using System;
using System.Collections.Generic;
using System.Text;

namespace Bombillas
{
    class BombillaClasica : Bombilla
    {
        public override string encender()
        {
            return ("Encendido clasica");
        }
        public override string aumentarIntensidad()
        {
            return ("Aumentando intensidad clasica");
        }
        public override string apagar()
        {
            return ("Apagado clasica");
        }
    }
}
