//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesManagementSouvenir_App
{
    using System;
    using System.Collections.Generic;
    
    public partial class HANG
    {
        public HANG()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public double DonGiaNhap { get; set; }
        public double DonGiaBan { get; set; }
        public int SoLuong { get; set; }
        public Nullable<int> MaChatLieu { get; set; }
        public string GhiChu { get; set; }
        public string AnhHH { get; set; }
        public Nullable<System.DateTime> NgayNhapKho { get; set; }
        public string NguonGoc { get; set; }
    
        public virtual CHATLIEU CHATLIEU { get; set; }
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}
