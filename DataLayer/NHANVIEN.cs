//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            this.BANGCONGs = new HashSet<BANGCONG>();
            this.HOPDONGs = new HashSet<HOPDONG>();
            this.NHANVIEN_PHUCAP = new HashSet<NHANVIEN_PHUCAP>();
            this.TANGCAs = new HashSet<TANGCA>();
            this.UNGLUONGs = new HashSet<UNGLUONG>();
            this.KHENTHUONGKILUATs = new HashSet<KHENTHUONGKILUAT>();
        }
    
        public int MaNV { get; set; }
        public string HoTen { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public byte[] HinhAnh { get; set; }
        public Nullable<int> MaPB { get; set; }
        public Nullable<int> MaBP { get; set; }
        public Nullable<int> MaCV { get; set; }
        public Nullable<int> MaTD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BANGCONG> BANGCONGs { get; set; }
        public virtual BOPHAN BOPHAN { get; set; }
        public virtual CHUCVU CHUCVU { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOPDONG> HOPDONGs { get; set; }
        public virtual PHONGBAN PHONGBAN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NHANVIEN_PHUCAP> NHANVIEN_PHUCAP { get; set; }
        public virtual TRINHDO TRINHDO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TANGCA> TANGCAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNGLUONG> UNGLUONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHENTHUONGKILUAT> KHENTHUONGKILUATs { get; set; }
    }
}
