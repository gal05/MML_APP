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
    
    public partial class PROVINCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROVINCIA()
        {
            this.DISTRITO = new HashSet<DISTRITO>();
        }
    
        public string COD_PROV { get; set; }
        public string DES_PROV { get; set; }
        public string COD_DPTO { get; set; }
        public string COD_PAIS { get; set; }
        public string ESTADO { get; set; }
        public Nullable<System.DateTime> FCONTROL { get; set; }
        public string USUARIO { get; set; }
    
        public virtual DEPARTAMENTO DEPARTAMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DISTRITO> DISTRITO { get; set; }
    }
}