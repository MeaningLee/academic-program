//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class Muon_sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Muon_sach()
        {
            this.Saches = new HashSet<Sach>();
        }
    
        public int Ma_muon { get; set; }
        public Nullable<int> Ma_docgia { get; set; }
        public Nullable<System.DateTime> thoigian_muon { get; set; }
        public Nullable<System.DateTime> thoigian_tra { get; set; }
        public Nullable<int> Ma_thuthu { get; set; }
        public string tinhtrang { get; set; }
    
        public virtual Thedocgia Thedocgia { get; set; }
        public virtual Thuthu Thuthu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}