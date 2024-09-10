using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    internal class ImageProduct
    {
       

        public int MaHinhAnh { get; set; }
        public int MaSP { get; set; }
        public string Url_Img { get; set; }


        public ImageProduct()
        {
        }
        public ImageProduct(int maHinhAnh, int maSP, string url_Img)
        {
            MaHinhAnh = maHinhAnh;
            MaSP = maSP;
            Url_Img = url_Img;
        }
    }
}
