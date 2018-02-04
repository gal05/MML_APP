using Microsoft.Owin.Security.OAuth;
using MML_APP.Datos;
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

            String condigo = context.UserName;
            String pass = context.Password;
            //USUARIO entry;
            List<USUARIO> usua = new List<USUARIO>();
            using (var db = new LocalUsuariosEntities())
            {
                usua = db.USUARIO.SqlQuery("SELECT * FROM USUARIO WHERE CODIGO='" + condigo + "' AND PASSWO='" + pass + "'").ToList();

                /*entry = db.USUARIO.Where
                    <USUARIO>(record =>
                    record.CODIGO == condigo  && record.PASSWO == pass).FirstOrDefault();//"NIEVESA"*/
            }


            
            

            if (usua.Count!=0)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, "ADMINISTRADOR"));
                identity.AddClaim(new Claim("username", "mguerra"));
                identity.AddClaim(new Claim(ClaimTypes.Name, "MILAGROS GUERRA ROJAS"));

                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password : "+pass+" and usuario : "+condigo);
                return;
            }
        }
    }
}