//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trabalho
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAB_Tempo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAB_Tempo()
        {
            this.TAB_Fato = new HashSet<TAB_Fato>();
        }
    
        public decimal Idf_Tempo { get; set; }
        public Nullable<decimal> Ano_Construcao { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAB_Fato> TAB_Fato { get; set; }
    }
}
