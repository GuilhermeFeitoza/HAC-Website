//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LojaMateriaisParaConstrucao.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCargo()
        {
            this.tbFuncionarios = new HashSet<tbFuncionario>();
        }
    
        public int CodigoCargo { get; set; }
        public string NomeCargo { get; set; }
        public string Abreviacao { get; set; }
        public string DescricaoCargo { get; set; }
        public Nullable<int> StatusCargo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFuncionario> tbFuncionarios { get; set; }
    }
}