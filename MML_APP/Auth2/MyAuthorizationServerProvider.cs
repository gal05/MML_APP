using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace MML_APP.Auth2
{
    public class MyAuthorizationServerProvider: OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated(); // 
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            if (context.UserName == "mguerra" && context.Password == "mguerra")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "ADMINISTRADOR"));
                identity.AddClaim(new Claim("username", "mguerra"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "MILAGROS GUERRA ROJAS"));
                identity.AddClaim(new Claim(ClaimTypes.GroupSid, "1"));
                context.Validated(identity);
            }
            else if (context.UserName == "user" && context.Password == "user")
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                identity.AddClaim(new Claim("username", "user"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "Anon imo"));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
        }
    }
}