using System;

namespace Kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas();

            kiuas.Nimi = "IKI";
            kiuas.Lämpö = 90;
            kiuas.Tila = "Päällä";
            kiuas.Kosteus = 20;

            kiuas.TulostaData();

            string kiuasTiedot = kiuas.ToString();
            Console.WriteLine(kiuasTiedot);
        }
    }
}
