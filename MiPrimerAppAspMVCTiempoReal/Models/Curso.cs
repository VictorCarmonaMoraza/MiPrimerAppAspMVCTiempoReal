//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiPrimerAppAspMVCTiempoReal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Curso()
        {
            this.SeccionCurso = new HashSet<SeccionCurso>();
        }
    
        public int IIDCURSO { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<int> IIDCATEGORIACURSO { get; set; }
        public decimal PRECIO { get; set; }
        public string CUPON { get; set; }
        public Nullable<int> BHABILITADO { get; set; }
        public string IMAGEN { get; set; }
    
        public virtual CategoriaCurso CategoriaCurso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SeccionCurso> SeccionCurso { get; set; }
    }
}
