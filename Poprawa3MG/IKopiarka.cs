using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
    interface IKopiarka : ISkanuj,IDrukarka
    {
        string Kopiuj()
        {
            return Skanuj();
            return Drukuj();
                
        }
    }
}
