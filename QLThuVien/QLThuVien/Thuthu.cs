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
    
    public partial class Thuthu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuthu()
        {
            this.Muon_sach = new HashSet<Muon_sach>();
        }
    
        public int Ma_thuthu { get; set; }
        public string Gio_truc { get; set; }
        public string Ghi_chu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muon_sach> Muon_sach { get; set; }
    }
}