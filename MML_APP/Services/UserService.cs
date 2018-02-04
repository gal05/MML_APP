using MML_APP.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MML_APP.Services
{
    public class UserService
    {
        public USUARIO ValidateUser(string codigo, string password)
        {
            var db = new LocalUsuariosEntities();
            USUARIO entry = db.USUARIO.Where
                <USUARIO>(record =>
                record.CODIGO == codigo &&
                record.PASSWO == password).FirstOrDefault();
            return entry;
        }
    }
}