using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    internal class Size
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public Size() { }
        public Size(int maDanhMuc, string tenDanhMuc)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }
    }
}
