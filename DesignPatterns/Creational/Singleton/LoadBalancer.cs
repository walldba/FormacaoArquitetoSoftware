using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Singleton
{
    internal sealed class LoadBalancer
    {
        private static readonly LoadBalancer Instance = new LoadBalancer();
        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "190.14.220.18"},
                new Server{ Name = "ServerII", IP = "190.14.220.19"},
                new Server{ Name = "ServerIII", IP = "190.14.220.20"},
                new Server{ Name = "ServerIV", IP = "190.14.220.21"},
                new Server{ Name = "ServerV", IP = "190.14.220.22"},
            };
        }

        public static LoadBalancer GetLoadBalancer()
        => Instance;

        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}