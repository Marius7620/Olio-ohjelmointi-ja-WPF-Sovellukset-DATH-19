﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Kiuas
{
    class Kiuas
    {
        public string Nimi { get; set; }
        public string Tila { get; set; }
        public int Lämpö { get; set; }
        public int Kosteus { get; set; }

        public void TulostaData()
        {
            Console.WriteLine("Sauna");
            Console.WriteLine("-- kiuas: " + Nimi);
            Console.WriteLine("-- Lämpö: " + Lämpö);
            Console.WriteLine("-- Tila: " + Tila);
            Console.WriteLine("-- Kosteus: " + Kosteus);
        }

        public string ToString()
        {
            string merkkijono = "Kiuas: " + Nimi + " Lämpö: " + Lämpö + " Astetta. Tila: " + Tila + " Kosteus: " + Kosteus + " ML.";

            return merkkijono;
        }
    }
}
