using System;
using System.Collections.Generic;
using System.Linq;

namespace Poprawa3MG
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Piosenka> lista = new List<Piosenka>();
            lista.Add(new Piosenka("Bronki", "Bronek", 4));
            lista.Add(new Piosenka("Alki", "Alek", 4));
            lista.Add(new Piosenka("Franki", "Franek", 4));
            lista.Add(new Piosenka("Stanki", "Stanek", 4));

            foreach (Piosenka item in lista )
            {
                Console.WriteLine("Tytul:"+item.Tytul+ "Autor:"+item.Autor+"Czas:"+item.Dlugosc);

            }
            var query1 = lista.Select(n => n).ToArray().OrderBy(a=>a);

        //    foreach (var item in query1)
         //   {
          //      Console.Write(item + " ");
          //  }
            var query2 = lista.Select(n => n).ToArray().OrderBy(b=>b);

          //  foreach (var item in query2)
          //  {
          //      Console.Write(item + " ");
         //   }



            foreach (Piosenka item in lista)
            {
               // Console.WriteLine($"Dlugosc:{ lista.Sum}

            }

            foreach (Piosenka item in lista)
            {
              //  Console.WriteLine($"Sort { );
            }
            
        }
    }
}
