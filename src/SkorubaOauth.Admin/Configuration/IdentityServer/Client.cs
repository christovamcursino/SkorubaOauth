using System.Collections.Generic;
using SkorubaOauth.Admin.Configuration.Identity;

namespace SkorubaOauth.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}






