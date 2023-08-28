using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public class PingIPV6 : BasePing
    {
        public override bool Init()
        {
            return true;
        }

        public bool SendPing()
        {
            return true;
        }

        internal void init()
        {
            throw new NotImplementedException();
        }
    }
}