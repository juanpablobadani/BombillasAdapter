using System;
using System.Collections.Generic;
using System.Text;

namespace Bombillas
{
    class BombillaModerna : Bombilla
    {
        public override string encender()
        {
            return ("Encendido moderno");
        }
        public override string aumentarIntensidad()
        {
            return ("Aumentando intensidad Moderno");
        }
        public override string apagar()
        {
            return ("Apagado moderno");
        }

    }
}
