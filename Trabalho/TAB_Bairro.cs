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
    
    public partial class TAB_Bairro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAB_Bairro()
        {
            this.TAB_Fato = new HashSet<TAB_Fato>();
        }
    
        public decimal Idf_Bairro { get; set; }
        public decimal Idf_Cidade { get; set; }
        public string Des_Bairro { get; set; }
        public Nullable<decimal> CEP { get; set; }
    
        public virtual TAB_Cidade TAB_Cidade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAB_Fato> TAB_Fato { get; set; }
    }
}
