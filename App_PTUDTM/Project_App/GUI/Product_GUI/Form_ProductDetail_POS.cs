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

namespace Project_App.GUI.Product_GUI
{
    public partial class Form_ProductDetail_POS : Form
    {

        private int _maSP;
        public Form_ProductDetail_POS(int maSP)
        {
            InitializeComponent();
            _maSP = maSP;
        }

        private void Form_ProductDetail_POS_Load(object sender, EventArgs e)
        {
            ProductItem_Service itemProduct = new ProductItem_Service(new ProductItem_DAO());
            List<ProductItem> listProductItem =  itemProduct.getAllProductItemByMaSP(_maSP);


            //đưa hình ảnh vào panle
            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 569; // Chiều rộng UC
            int itemHeight = 55;// Chiều cao UC
            int spacing = 2; // khoảng cách 

            Panel_ListProductItem.AutoScroll = true;

            foreach (var item in listProductItem)
            {
                Uc_ProductDetailPos productDetail = new Uc_ProductDetailPos()
                {
                    Id = item.MaChiTiet,
                    Id_color = item.MaMau,
                    Id_size = item.MaKichThuoc,
                    Id_SoLuongTon = item.SoLuongTon,
                };
               

                if (xOffset + itemWidth > Panel_ListProductItem.Width)
                {
                    xOffset = 0; // Reset vị trí ngang
                    yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
                }

                // Đặt vị trí cho UserControl
                productDetail.Location = new System.Drawing.Point(xOffset, yOffset);

                // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
                xOffset += itemWidth + spacing;

                // Thêm UserControl vào panel_Products
                Panel_ListProductItem.Controls.Add(productDetail);
            }
        }

        private void Panel_ListProductItem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
