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
    
    public partial class HOADON
    {
        public int MaHD { get; set; }
        public int MaHang { get; set; }
        public int MaNV { get; set; }
        public System.DateTime NgayBan { get; set; }
        public int MaKH { get; set; }
        public double TongTien { get; set; }
    
        public virtual HANG HANG { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
