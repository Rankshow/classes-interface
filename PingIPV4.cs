using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class PingIPV4 : BasePing
    {

        public override bool Init()
        {
            return true;
        }

        // * Different implementation
        public bool SendPing()
        {
            return true;
        }
    }
}