//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLiSinhVien
{
    using System;
    using System.Collections.Generic;
    
    public partial class Diem
    {
        public int masv { get; set; }
        public int mamh { get; set; }
        public Nullable<double> diemGiuaKi { get; set; }
        public Nullable<double> diemCuoiKi { get; set; }
    
        public virtual MonHoc MonHoc { get; set; }
        public virtual SinhVien SinhVien { get; set; }

        public Diem(int masv, int mamh, double? diemGiuaKi, double? diemCuoiKi)
        {
            this.masv = masv;
            this.mamh = mamh;
            this.diemGiuaKi = diemGiuaKi;
            this.diemCuoiKi = diemCuoiKi;
        }

        public Diem()
        {
        }
    }
}
