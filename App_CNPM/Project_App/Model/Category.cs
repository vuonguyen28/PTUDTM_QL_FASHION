using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    public class Category
    {
        public int MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

        public Category() {}
        public Category(int maDanhMuc, string tenDanhMuc)
        {
            MaDanhMuc = maDanhMuc;
            TenDanhMuc = tenDanhMuc;
        }
    }

}
