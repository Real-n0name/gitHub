using System;
using System.Collections.Generic;
using System.Text;

namespace EgorKarachev
{
    interface LogInterface
    {
        public LogInterface log(string str);
        public LogInterface write();
    }
}
