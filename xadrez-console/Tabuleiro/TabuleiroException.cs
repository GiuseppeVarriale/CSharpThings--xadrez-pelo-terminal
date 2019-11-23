using System;
using System.Collections.Generic;
using System.Text;

namespace TabuleiroNS
{
    class TabuleiroException : Exception 
    {
        public TabuleiroException(string msg) : base(msg) 
        { 
        }
    }
}
