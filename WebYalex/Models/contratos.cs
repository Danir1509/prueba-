//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebYalex.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class contratos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public contratos()
        {
            this.entrega = new HashSet<entrega>();
        }

        [Display(Name = "Id Contrato")]
        public int id_contrato { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime fecha { get; set; }
        [Display(Name = "Id Cliente")]
        public int id_cliente { get; set; }
        [Display(Name = "Id Alquiler")]
        public int id_alquiler { get; set; }
        [Display(Name = "Dias")]
        public int dias { get; set; }
        [Display(Name = "Precio")]
        public decimal precio { get; set; }
        [Display(Name = "Telefono")]
        public string telefono { get; set; }
        [Display(Name = "Correo")]
        public string correo { get; set; }
        [Display(Name = "Referencia")]
        public string referencia { get; set; }
        [Display(Name = "Tipo Pago")]
        public string tipo_pago { get; set; }
        [Display(Name = "Numero Referencia")]
        public string num_referencia { get; set; }
        [Display(Name = "Total Renta")]
        public decimal total_renta { get; set; }
        [Display(Name = "Id Vehiculo")]
        public int id_vehiculo { get; set; }

        public virtual alquileres alquileres { get; set; }
        public virtual clientes clientes { get; set; }
        public virtual vehiculo vehiculo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<entrega> entrega { get; set; }
    }
}
