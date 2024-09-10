using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_App
{
    public partial class Uc_ProductDetailPos : UserControl
    {
        private int id;
        private int id_color;
        private int id_size;
        private int id_QuantityStock;
        private int id_SoLuongTon;
       

        public int Id { get => id; set => id = value; }
        public int Id_color { get => id_color; set => id_color = value; }
        public int Id_size { get => id_size; set => id_size = value; }
        public int Id_QuantityStock { get => id_QuantityStock; set => id_QuantityStock = value; }
        public int Id_SoLuongTon { get => id_SoLuongTon; set => id_SoLuongTon = value; }

        public Uc_ProductDetailPos()
        {
            InitializeComponent();
        }
        private void Uc_ProductDetailPos_Load(object sender, EventArgs e)
        {
            txt_Number.Text = id_QuantityStock.ToString();
            label_Color.Text = Id_color.ToString();
            label_Size.Text = Id_size.ToString();
            lable_IDProduct.Text = Id.ToString();
            label_SoLuongTon.Text = Id_SoLuongTon.ToString();
        }

       

       
    }
}
