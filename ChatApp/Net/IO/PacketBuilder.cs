﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.Net.IO
{
    class PacketBuilder
    {
        MemoryStream _ms;
        
        public PacketBuilder()
        {
            _ms = new MemoryStream(0);
        }

        public void WriteOpCode(byte opcode)
        {
            _ms.WriteByte(opcode);

        }

        public void WriteMessage(string msg)
        {
            var msLength = msg.Length;
            _ms.Write(BitConverter.GetBytes(msLength));
            _ms.Write(Encoding.ASCII.GetBytes(msg));
        }

        public byte[] GetPacketBytes()
        {
            return _ms.ToArray();
        }

    }
}
