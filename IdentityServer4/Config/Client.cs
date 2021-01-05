using System.Collections.Generic;

namespace IdentityServer4.Controllers
{
    public class Client
    {
        public static IEnumerable<Client> Configuration()
        {
            return new List<Client>
            {
                new Client
                {
                ClientId = "0931e822-7bb5-4971-bf64-9c20520c2afb",
                ClientSecrets = new List<Secret>
                {
                    new Secret("d355c1fb-5b8a-4881-9abc-53dba0b62286".Sha256())
                },
                AllowedScopes = new List<string> { "Hotel_Real" },
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AccessTokenLifetime = 3600

                }
            };
        }
    }
}
