//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arac_Satis_Website.Models.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class AracYakıt
    {
        public int ARACYAKITID { get; set; }
        public Nullable<decimal> ARACORTYAKIT { get; set; }
        public Nullable<decimal> ARACSEHIRICIYAKIT { get; set; }
        public Nullable<decimal> ARACSEHIRDISIYAKIT { get; set; }
        public Nullable<int> ARACYAKITDEPO { get; set; }
        public Nullable<int> ILAN { get; set; }
    
        public virtual Ilan Ilan1 { get; set; }
    }
}
