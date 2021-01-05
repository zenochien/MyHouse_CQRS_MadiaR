using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer4.Controllers
{
    public class ApiResources
    {
        public static IEnumerable<ApiResource> Configuration()
        {
            return new List<ApiResource>
            {
                new ApiResource("Hotel-Api")
                {
                    Scopes = new List<string> {"Hotel_Read", "Hotel_Write"}
                }
            };
        }
    }
}
