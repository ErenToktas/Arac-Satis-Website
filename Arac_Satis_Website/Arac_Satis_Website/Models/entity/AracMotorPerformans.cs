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
    
    public partial class AracMotorPerformans
    {
        public int ARACPERFORMANSID { get; set; }
        public string ARACCEKIS { get; set; }
        public string ARACSILINDIR { get; set; }
        public Nullable<int> ARACTORK { get; set; }
        public Nullable<int> ARACMOTORHACIM { get; set; }
        public Nullable<int> ARACMOTORGUC { get; set; }
        public Nullable<int> ARACMAXGUC { get; set; }
        public Nullable<int> ARACMINGUC { get; set; }
        public Nullable<decimal> ARACHIZLANMA { get; set; }
        public Nullable<int> ARACMAXHIZ { get; set; }
        public Nullable<int> ILAN { get; set; }
    
        public virtual Ilan Ilan1 { get; set; }
    }
}
