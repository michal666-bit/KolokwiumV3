using System;
using System.Collections.Generic;
using System.Text;

namespace Poprawa3MG
{
    class Poczta
    {
        public event EventHandler NowyMail;

        public void nowyMail()
        {
            NowyMail.Invoke(this, EventArgs.Empty);

        }
    }
}
