using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MML_APP.Models
{
    public class TupaModels
    {
        public string DES_MERCADO { get; set; }
        public string CLADOC { get; set; }
        public string DESDOC { get; set; }
        public string SERDOC { get; set; }
        public string PTOCOB { get; set; }
        public string CODING { get; set; }
        public string DESC_INGRESO { get; set; }
        public string NUMDOC { get; set; }
        public string NOMCONT { get; set; }
        public Nullable<System.DateTime> FECHEMIS { get; set; }
        public string PUESTO { get; set; }
        public string PASAJE { get; set; }
        public string LETRA { get; set; }
        public Nullable<decimal> NUM_ORDEN { get; set; }//esto era string :v
        public string ESTADO { get; set; }
        public string ANODEU { get; set; }
        public Nullable<decimal> BASDET { get; set; }
        public Nullable<decimal> MORDET { get; set; }
        public Nullable<decimal> IGVDET { get; set; }
        public Nullable<decimal> TOTDET { get; set; }
        public Nullable<System.DateTime> CONTROL { get; set; }
    }
}