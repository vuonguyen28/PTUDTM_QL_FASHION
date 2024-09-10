using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductItem
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string maSP;
        public string MaSP { get => maSP; set => maSP = value; }

        


        // Thuộc tính cho hình ảnh sản phẩm
        public Image ProductImage
        {
            get { return pictureBox_Url_Img.Image; }
            set { pictureBox_Url_Img.Image = value; }
        }

        // Thuộc tính cho tên sản phẩm
        public string ProductName
        {
            get { return Lable_NameProduct.Text; }
            set { Lable_NameProduct.Text = value; }
        }

        // Thuộc tính cho giá sản phẩm
        public decimal ProductPrice
        {
            get { return decimal.Parse(label_Price.Text.Replace("₫", "").Trim()); }
            set { label_Price.Text = $"{value:C}"; } // Format theo dạng tiền tệ
        }

        // Thuộc tính cho phần trăm giảm giá
        public decimal DiscountPercentage
        {
            get { return decimal.Parse(lable_discount.Text.Replace("%", "").Trim()); }
            set { lable_discount.Text = $"{value}%"; }
        }

        

        private void btn_cart_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đã thêm {ProductName} vào giỏ hàng với giá {ProductPrice:C} và giảm giá {DiscountPercentage}%.");
        }





















        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Url_Img_Click(object sender, EventArgs e)
        {

        }

        private void Lable_NameProduct_Click(object sender, EventArgs e)
        {

        }

        private void lable_discount_Click(object sender, EventArgs e)
        {

        }

        private void label_Price_Click(object sender, EventArgs e)
        {

        }

      
    }
}
