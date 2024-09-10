using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    public class ProductItem
    {
        private int maChiTiet;
        private int maSP;
        private int maMau;
        private int maKichThuoc;
        private int soLuongTon;

        public int MaChiTiet { get => maChiTiet; set => maChiTiet = value; }
        public int MaSP { get => maSP; set => maSP = value; }
        public int MaMau { get => maMau; set => maMau = value; }
        public int MaKichThuoc { get => maKichThuoc; set => maKichThuoc = value; }
        public int SoLuongTon { get => soLuongTon; set => soLuongTon = value; }

        public ProductItem() { }
        public ProductItem(int maChiTiet, int maSP, int maMau, int maKichThuoc, int soLuongTon)
        {
            this.maChiTiet = maChiTiet;
            this.maSP = maSP;
            this.maMau = maMau;
            this.maKichThuoc = maKichThuoc;
            this.soLuongTon = soLuongTon;
        }
    }
}
