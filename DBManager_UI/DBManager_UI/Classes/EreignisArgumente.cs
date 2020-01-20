using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBManager_UI
{
    public class EreignisArgumente : EventArgs
    {
        public bool meldung;
        public EreignisArgumente(bool s)
        {
            this.meldung = s;
        }
    }
}
