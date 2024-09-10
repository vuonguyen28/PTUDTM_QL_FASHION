using Connect_Mysql;
using ControlLibrary;
using Project_App.DataAccess;
using Project_App.Model;
using Project_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Project_App.GUI
{
    public partial class FormPOS : Form
    {

        private ConnectMysql _dbConnection;
        public FormPOS()
        {
            InitializeComponent();
        }

        private void panel_contentProduct_Paint(object sender, PaintEventArgs e)
        {

        }


       

        private void FormPOS_Load(object sender, EventArgs e)
        {
            // Bật cuộn cho panel_Products
            panel_contentProduct.AutoScroll = true;

            var productDao = new Product_DAO();
            var imageDAO = new ImageProduct_DAO();
            ImageProduct_Services imageService = new ImageProduct_Services(imageDAO);
            List<Product> products = productDao.GetAllProducts();

            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 156; // Chiều rộng của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
            int itemHeight = 237; // Chiều cao của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
            int spacing = 2; // Khoảng cách giữa các UserControl, thay đổi tùy theo thiết kế của bạn

            panel_contentProduct.SuspendLayout();
            foreach (var product in products)
            {
                Uc_ProductItemPos productItem = new Uc_ProductItemPos
                {
                    MaSP = product.MaSP,
                    TenSP1 = product.TenSP,
                    Gia1 = product.Gia,
                    Sale = product.PhanTramGiamGia,
                    Size = new System.Drawing.Size(itemWidth, itemHeight), // Thiết lập kích thước của UserControl
                };

                // Lấy hình ảnh đầu tiên theo MaSP
                var image = imageService.GetFirstImageByMaSP(product.MaSP);

                if (image != null)
                {
                    // Nếu có hình ảnh, load vào productItem
                    productItem.HinhAnh = image.Url_Img;
                }
                else
                {

                    // xử lý trả về hình ảnh mặt định nếu ko tìm thấy
                }

                // Kiểm tra nếu UserControl không còn đủ không gian theo chiều ngang
                if (xOffset + itemWidth > panel_contentProduct.Width)
                {
                    xOffset = 0; // Reset vị trí ngang
                    yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
                }

                // Đặt vị trí cho UserControl
                productItem.Location = new Point(xOffset, yOffset);

                // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
                xOffset += itemWidth + spacing;

                // Thêm UserControl vào panel_Products
                panel_contentProduct.Controls.Add(productItem);
            }

            panel_contentProduct.ResumeLayout();

        }

        private void icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientTileButton4_Click(object sender, EventArgs e)
        {

        }
    }
}
