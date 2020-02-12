using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
   public static class ExtensioinMethod
    {
        public static int E(this int[] tablica)
        {
            
            for (int i = 0; i < tablica.Length; i++)
            {
                 return tablica[i] * 10;
            }
            return 0;
        }
    }
}
