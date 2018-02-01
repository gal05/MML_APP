using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MML_APP.Metodos;
using System.Collections.Specialized;
using System.Security.Claims;

namespace MML_APP.Controllers
{
    public class LoginDummyController : Controller
    {

        [HttpGet]
        [Authorize]
        public ContentResult Prueba(String passw,String usuario)
        {

            /*NameValueCollection data = new NameValueCollection();
            data.Add("username", usuario);
            data.Add("password", passw);
            data.Add("grant_type", "password");*/
            //return RedirectToRoutePermanent("/api/token", data);
            //Redirect("/api/token");

             //Metodos.Metodos.toAscii(passw);

            return Content("original : "+passw+" con ASCII : "+ Metodos.Metodos.toAscii(passw));
        }

        [HttpGet]
        [Authorize]
        public JsonResult InfoClient()
        {
            var identity =(ClaimsIdentity) User.Identity;
            var roles = identity.Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value);

            var jsondata = new List<object>();
            jsondata.Add(new {usuario=identity.Name,cargo=string.Join(",",roles.ToList()),estado="1" });


            return Json(jsondata,JsonRequestBehavior.AllowGet);
        }

    }
}
