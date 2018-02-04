using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MML_APP.Models
{
    public class ClienteModels
    {
        public string CODIGO { get; set; }
        public string PASSWO { get; set; }
        public string NOMBRE { get; set; }
        public string ABREVI { get; set; }
        public Nullable<System.DateTime> INICIO { get; set; }
        public string CARGO { get; set; }
        public string NIVEL { get; set; }
        public string OFICINA { get; set; }
        public string ESTADO { get; set; }
        public string C_USUARIO { get; set; }
        public Nullable<System.DateTime> F_CONTROL { get; set; }
        public string COD_MERCADO { get; set; }
    }
}