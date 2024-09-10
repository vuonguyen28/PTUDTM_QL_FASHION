using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_App.Model
{
    public class Color
    {
        public int MaMau { get; set; }
        public string TenMau { get; set; }
        public string HEXCODE { get; set; }

        public Color() { }
        public Color(int maMau, string tenMau, string hEXCODE)
        {
            MaMau = maMau;
            TenMau = tenMau;
            HEXCODE = hEXCODE;
        }
    }
}
