//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class SANH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANH()
        {
            this.TIECCUOIs = new HashSet<TIECCUOI>();
        }
    
        public string TenSanh { get; set; }
        public string ID_LoaiSanh { get; set; }
        public Nullable<int> SoLuonBanTD { get; set; }
        public Nullable<double> DonGiaBanTT { get; set; }
        public Nullable<bool> TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public string ID_Sanh { get; set; }
    
        public virtual LoaiSanh LoaiSanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TIECCUOI> TIECCUOIs { get; set; }
    }
}
