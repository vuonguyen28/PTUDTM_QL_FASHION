using Project_App.GUI.Product_GUI;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ControlLibrary
{
    public partial class Uc_ProductItemPos : UserControl
    {
        private int maSP;
        private string tenSP;
        private decimal gia;
        private double sale;
        private string hinhAnh;

        public int MaSP { get => maSP; set => maSP = value; }
        public string TenSP1 { get => tenSP; set => tenSP = value; }
        public decimal Gia1 { get => gia; set => gia = value; }
        public double Sale { get => sale; set => sale = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }

        public Uc_ProductItemPos()
        {
            InitializeComponent();
        }

        private void Uc_ProductItemPos_Load(object sender, EventArgs e)
        {
            LoadProductInfo();
            LoadProductImage();
        }

        private void LoadProductInfo()
        {
            // Đặt thông tin sản phẩm vào các điều khiển
            Lable_NameProduct.Text = TenSP1;
            label_Sale.Text = Sale.ToString() + "%";
            label_Price.Text = Gia1.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));

            decimal discountAmount = CalculateDiscountAmount(Gia1, (decimal)Sale);
            if (discountAmount > 0)
            {
                lable_discount.Text = discountAmount.ToString("C0", CultureInfo.GetCultureInfo("vi-VN"));
            }

            if (Sale == 0)
            {
                label_Sale.Text = "";
                label_Price.Text = "";
            }
        }

        private void LoadProductImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(HinhAnh))
                {
                    pictureBox_Url_Img.Load(HinhAnh);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh sản phẩm: " + ex.Message);
            }
        }

        // Tính giá tiền sau giảm giá
        public decimal CalculateDiscountAmount(decimal price, decimal discountPercentage)
        {
            return price - (price * discountPercentage) / 100;
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_addCart_Click(object sender, EventArgs e)
        {
            Form_ProductDetail_POS form = new Form_ProductDetail_POS(MaSP);
            form.Show();
        }
    }
}
