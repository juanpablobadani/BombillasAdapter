using System;
using System.Collections.Generic;
using System.Text;

namespace Bombillas
{
    class BombillaAdapter : Bombilla
    {
        private Vela vela = new Vela();

        public override string encender()
        {
            return vela.PrenderFuego();
        }
        public override string aumentarIntensidad()
        {
            return vela.EcharCombustible();
        }
        public override string apagar()
        {
            return vela.SoplarParaApagar();
        }
    }
}
