using System;
using System.Collections.Generic;
using System.Text;

namespace lab4.EgorKarachev
{
    class EgorException:Exception
    {
        public EgorException(string message) : base(message)
        {
        }
    }
}
