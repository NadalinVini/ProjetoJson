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
    
    public partial class Imovel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Imovel()
        {
            this.FATO = new HashSet<FATO>();
        }
    
        public decimal Idf_Imovel { get; set; }
        public string Categoria { get; set; }
        public string Status_ { get; set; }
        public string Faixa_Area { get; set; }
        public string Faixa_Area_Privada { get; set; }
        public string Faixa_Preco_IPTU { get; set; }
        public string Faixa_Area_Condominio { get; set; }
        public Nullable<bool> Flg_Planta { get; set; }
        public Nullable<bool> Flg_Dependencia { get; set; }
        public Nullable<bool> Flg_Sacada { get; set; }
        public Nullable<bool> Flg_Portaria { get; set; }
        public Nullable<bool> Flg_Elevador { get; set; }
        public string Churrasqueira { get; set; }
        public string Faixa_Dormintorios { get; set; }
        public string Faixa_Suites { get; set; }
        public string Faixa_Vagas { get; set; }
        public string Faixa_Banheiros { get; set; }
        public string Faixa_Valor_Venda { get; set; }
        public Nullable<bool> Flg_Mostra_mapa { get; set; }
        public string Faixa_Valor_Aluguel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FATO> FATO { get; set; }
    }
}
