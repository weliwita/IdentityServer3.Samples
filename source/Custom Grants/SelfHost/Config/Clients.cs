﻿using IdentityServer3.Core.Models;
using System.Collections.Generic;

namespace IdentityServer.Host.Config
{
    public class Clients
    {
        public static List<Client> Get()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientName = "Custom Grant Client",
                    Enabled = true,

                    ClientId = "client",
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256()),
                    },
                    
                    Flow = Flows.Custom,
                    AllowedCustomGrantTypes = new List<string>
                    {
                        "custom"
                    },
                    
                    AllowedScopes = new List<string>
                    { 
                        "read",
                        "write",
                    },
                }
            };
        }
    }
}