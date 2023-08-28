using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes
{
    public abstract class BasePing
    {
        public int HostAddresss { get; set; }
        public int DestAddress { get; set; }    
        public string Data { get; set; }    

        public abstract bool Init();
    }
}