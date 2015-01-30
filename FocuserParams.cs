using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASAFocuser
{
    class FocuserParams
    {
        public FocuserParams()
        {
            connected = false;
            errMsg = "";
        }
        public bool connected;
        public string errMsg;
    }
}
