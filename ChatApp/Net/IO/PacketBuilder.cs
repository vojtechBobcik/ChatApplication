using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Net.IO
{
    internal class PacketBuilder
    {
        MemoryStream _ms;
        
        public PacketBuilder()
        {
            _ms = new MemoryStream(0);
        }
    }
}
