using System;
using System.Collections.Generic;
using System.Text;

namespace Bombillas
{
    abstract class Bombilla
    {
        public abstract string encender();
        public abstract string aumentarIntensidad();
        public abstract string apagar();
    }
}
