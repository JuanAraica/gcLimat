//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gcLimat.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_EQUIPO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_EQUIPO()
        {
            this.tbl_MANTENIMIENTO = new HashSet<tbl_MANTENIMIENTO>();
            this.tbl_PRUEBACROMATOGRAFICA = new HashSet<tbl_PRUEBACROMATOGRAFICA>();
            this.tbl_PRUEBAELECTRICA = new HashSet<tbl_PRUEBAELECTRICA>();
            this.tbl_PRUEBAFISICA = new HashSet<tbl_PRUEBAFISICA>();
            this.tbl_PRUEBAQUIMICA = new HashSet<tbl_PRUEBAQUIMICA>();
            this.tbl_RECOLECCIONMUESTRA = new HashSet<tbl_RECOLECCIONMUESTRA>();
            this.tbl_REPORTE = new HashSet<tbl_REPORTE>();
        }
    
        public string idEquipo { get; set; }
        public string tipoEquipo { get; set; }
        public string region { get; set; }
        public string potenciaMaxima { get; set; }
        public string serie { get; set; }
        public string marca { get; set; }
        public string subEstacion { get; set; }
        public string tipoRefrigeracion { get; set; }
        public string tension { get; set; }
        public string cantidadFase { get; set; }
        public string cantidadAceite { get; set; }
        public string annio { get; set; }
        public string MVA { get; set; }
        public string relacioTension { get; set; }
        public string humedadRelativa { get; set; }
        public string temperaturaAmbiente { get; set; }
        public string temperaturaEquipo { get; set; }
        public string ultimoReporte { get; set; }
        public string ultimoMantenimiento { get; set; }
        public string ultimoMuestreo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_MANTENIMIENTO> tbl_MANTENIMIENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRUEBACROMATOGRAFICA> tbl_PRUEBACROMATOGRAFICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRUEBAELECTRICA> tbl_PRUEBAELECTRICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRUEBAFISICA> tbl_PRUEBAFISICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_PRUEBAQUIMICA> tbl_PRUEBAQUIMICA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_RECOLECCIONMUESTRA> tbl_RECOLECCIONMUESTRA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_REPORTE> tbl_REPORTE { get; set; }
    }
}
