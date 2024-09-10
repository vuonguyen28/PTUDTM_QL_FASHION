using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    public class Product
    {
       
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Gia { get; set; }
        public string MoTa { get; set; }
        public double PhanTramGiamGia { get; set; }
        public int MaDanhMuc { get; set; }
        public int MaNhaCungCap { get; set; }
        public string TrinhTrang { get; set; }


        public Product() { }
        public Product(int maSP, string tenSP, decimal gia, string moTa, double phanTramGiamGia, int maDanhMuc, int maNhaCungCap, string trinhTrang)
        {
            MaSP = maSP;
            TenSP = tenSP;
            Gia = gia;
            MoTa = moTa;
            PhanTramGiamGia = phanTramGiamGia;
            MaDanhMuc = maDanhMuc;
            MaNhaCungCap = maNhaCungCap;
            TrinhTrang = trinhTrang;
        }

    }

}
