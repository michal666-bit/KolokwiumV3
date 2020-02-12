using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
    interface IDrukarka : ISkanuj
    {
        public string Drukuj()
        {
            return "A";
        }
    }
}
