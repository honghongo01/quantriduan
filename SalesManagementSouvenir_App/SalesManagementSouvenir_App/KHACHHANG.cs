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
    
    public partial class KHACHHANG
    {
        public KHACHHANG()
        {
            this.HOADONs = new HashSet<HOADON>();
        }
    
        public int MaKH { get; set; }
        public string TenKhach { get; set; }
        public string DiaChiKH { get; set; }
        public string SDTKH { get; set; }
    
        public virtual ICollection<HOADON> HOADONs { get; set; }
    }
}