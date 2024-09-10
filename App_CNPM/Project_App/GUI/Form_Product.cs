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

namespace Project_App
{
    public partial class Form_Product : Form
    {
        private ConnectMysql _dbConnection;


        private async void Form_Product_Load(object sender, EventArgs e)
        {

            // Bật cuộn cho panel_Products
            panel_Products.AutoScroll = true;

            var productDao = new Product_DAO();
            var imageDAO = new ImageProduct_DAO();
            ImageProduct_Services imageService = new ImageProduct_Services(imageDAO);
            List<Product> products = productDao.GetAllProducts();

            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 269; // Chiều rộng của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
            int itemHeight = 85; // Chiều cao của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
            int spacing = 2; // Khoảng cách giữa các UserControl, thay đổi tùy theo thiết kế của bạn

            panel_Products.SuspendLayout();
            foreach (var product in products)
            {
                Uc_ProductItem productItem = new Uc_ProductItem
                {
                    MaSP = product.MaSP,
                    TenSP = product.TenSP,
                    Gia = product.Gia,
                    Sale = (decimal)product.PhanTramGiamGia,
                    Size = new System.Drawing.Size(itemWidth, itemHeight), // Thiết lập kích thước của UserControl
                };

              
                //var image = imageService.GetFirstImageByMaSP(product.MaSP);

                //if (image != null)
                //{
                //    productItem.HinhAnh = image.Url_Img;
                //}
               
                

                // Kiểm tra nếu UserControl không còn đủ không gian theo chiều ngang
                if (xOffset + itemWidth > panel_Products.Width)
                {
                    xOffset = 0; // Reset vị trí ngang
                    yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
                }

                // Đặt vị trí cho UserControl
                productItem.Location = new Point(xOffset, yOffset);

                // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
                xOffset += itemWidth + spacing;

                // Thêm UserControl vào panel_Products
                panel_Products.Controls.Add(productItem);
            }

            panel_Products.ResumeLayout();












            //panel_Products.AutoScroll = true;

            //var productDao = new Product_DAO();
            //var imageDAO = new ImageProduct_DAO();
            //ImageProduct_Services imageService = new ImageProduct_Services(imageDAO);

            //List<Product> products = await Task.Run(() => productDao.GetAllProducts());

            //int xOffset = 0;
            //int yOffset = 0;
            //int itemWidth = 199;
            //int itemHeight = 293;
            //int spacing = 10;

            //panel_Products.SuspendLayout();

            //var tasks = products.Select(async product =>
            //{
            //    Uc_ProductItemPos productItem = new Uc_ProductItemPos
            //    {
            //        MaSP = product.MaSP,
            //        TenSP1 = product.TenSP,
            //        Gia1 = product.Gia,
            //        Sale = product.PhanTramGiamGia,
            //        Size = new System.Drawing.Size(itemWidth, itemHeight)
            //    };

            //    var image = await Task.Run(() => imageService.GetFirstImageByMaSP(product.MaSP));

            //    if (image != null)
            //    {
            //        productItem.HinhAnh = image.Url_Img;
            //    }
            //    else
            //    {
            //        productItem.HinhAnh = "path_to_default_image"; // Hình ảnh mặc định nếu không có hình ảnh
            //    }

            //    if (xOffset + itemWidth > panel_Products.Width)
            //    {
            //        xOffset = 0;
            //        yOffset += itemHeight + spacing;
            //    }

            //    productItem.Location = new Point(xOffset, yOffset);
            //    xOffset += itemWidth + spacing;

            //    panel_Products.Controls.Add(productItem);
            //});

            //await Task.WhenAll(tasks);

            //panel_Products.ResumeLayout();
        }
        public Form_Product()
        {
            InitializeComponent();
        }

        private void panel_Products_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {

        }

        //private void Form_Product_Load(object sender, EventArgs e)
        //{
        //    // Bật cuộn cho panel_Products
        //    panel_Products.AutoScroll = true;

        //    var productDao = new Product_DAO();
        //    var imageDAO = new ImageProduct_DAO();
        //    ImageProduct_Services imageService = new ImageProduct_Services(imageDAO);
        //    List<Product> products = productDao.GetAllProducts();

        //    int xOffset = 0; // Vị trí hiện tại theo chiều ngang
        //    int yOffset = 0; // Vị trí hiện tại theo chiều dọc
        //    int itemWidth = 199; // Chiều rộng của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
        //    int itemHeight = 293; // Chiều cao của mỗi UserControl, thay đổi tùy theo thiết kế của bạn
        //    int spacing = 10; // Khoảng cách giữa các UserControl, thay đổi tùy theo thiết kế của bạn


        //    panel_Products.SuspendLayout();
        //    foreach (var product in products)
        //    {
        //        Uc_ProductItemPos productItem = new Uc_ProductItemPos
        //        {
        //            MaSP = product.MaSP,
        //            TenSP1 = product.TenSP,
        //            Gia1 = product.Gia,
        //            Sale = product.PhanTramGiamGia,
        //            Size = new System.Drawing.Size(itemWidth, itemHeight), // Thiết lập kích thước của UserControl
        //        };

        //        // Lấy hình ảnh đầu tiên theo MaSP
        //        var image = imageService.GetFirstImageByMaSP(product.MaSP);

        //        if (image != null)
        //        {
        //            // Nếu có hình ảnh, load vào productItem
        //            productItem.HinhAnh = image.Url_Img;
        //        }
        //        else
        //        {

        //            // xử lý trả về hình ảnh mặt định nếu ko tìm thấy
        //        }

        //        // Kiểm tra nếu UserControl không còn đủ không gian theo chiều ngang
        //        if (xOffset + itemWidth > panel_Products.Width)
        //        {
        //            xOffset = 0; // Reset vị trí ngang
        //            yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
        //        }

        //        // Đặt vị trí cho UserControl
        //        productItem.Location = new Point(xOffset, yOffset);

        //        // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
        //        xOffset += itemWidth + spacing;

        //        // Thêm UserControl vào panel_Products
        //        panel_Products.Controls.Add(productItem);
        //    }

        //    panel_Products.ResumeLayout();


        //}









    }
}
