﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ChatServer
{
    class Client
    {
        public string UserName { get; set; }
        public Guid UID { get; set; }
        public TcpClient ClientSocket{ get; set; }

        public Client(TcpClient client)
        {
            ClientSocket = client;
            UID = Guid.NewGuid(); 
            Console.WriteLine($"[{DateTime.Now}]: Client has connected with the username: {UserName} ");
        }
    }
}
