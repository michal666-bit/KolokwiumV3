using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
    class Piosenka
    {
        public Piosenka(string tytul, string autor, int dlugosc)
        {
            Tytul = tytul;
            Autor = autor;
            Dlugosc = dlugosc;
        }

        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int Dlugosc { get; set; }

    }
}
