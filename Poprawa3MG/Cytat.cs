using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
    class Cytat
    {
        public Cytat(string autor, string tytul, string dataWydania, string miejsceWydania, string wydawnictwo)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            MiejsceWydania = miejsceWydania;
            Wydawnictwo = wydawnictwo;
        }

        public string Autor { get; set; }
        public string Tytul { get; set; }
        public string DataWydania { get; set; }
        public string MiejsceWydania { get; set; }
        public string Wydawnictwo { get; set; }

        public void Deconstruct(out string autor, out string dataWydania)
        {
            autor = Autor;
            dataWydania = DataWydania;
          
        }
        public void Deconstruct(out string tytul, out string autor, out string miesjceWydania, out string wydawnictwo)
        {
            tytul = Tytul;
            autor = Autor;
            miesjceWydania = MiejsceWydania;
            wydawnictwo = Wydawnictwo;



        }


    }
}
