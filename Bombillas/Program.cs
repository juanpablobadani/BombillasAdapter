using System;

namespace Bombillas
{
    class Program
    {
        static void Main(string[] args)
        {
            BombillaClasica bombilla = new BombillaClasica();
            Console.WriteLine(bombilla.encender());
            Console.WriteLine(bombilla.aumentarIntensidad());
            Console.WriteLine(bombilla.apagar());

            Console.ReadLine();

            BombillaModerna moderna = new BombillaModerna();
            Console.WriteLine(moderna.encender());
            Console.WriteLine(moderna.aumentarIntensidad());
            Console.WriteLine(moderna.apagar());

            Console.ReadLine();

            BombillaAdapter usarVela = new BombillaAdapter();
            Console.WriteLine(usarVela.encender());
            Console.WriteLine(usarVela.aumentarIntensidad());
            Console.WriteLine(usarVela.apagar());

            Console.ReadLine();
        }
    }
}
