//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MML_APP.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class ACCESO
    {
        public string C_MODULO { get; set; }
        public string CODIGO { get; set; }
        public string ACTIVO { get; set; }
        public string C_USUARIO { get; set; }
        public Nullable<System.DateTime> F_CREACION { get; set; }
        public string ESTADO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
        public virtual MODULO MODULO { get; set; }
    }
}