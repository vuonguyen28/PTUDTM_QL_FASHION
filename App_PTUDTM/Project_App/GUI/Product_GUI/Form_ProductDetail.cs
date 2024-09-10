using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_App.Services;
using Project_App.DataAccess;
using Project_App.Model;
using System.Web.UI.WebControls;
using ControlLibrary;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Drawing;
using MySql.Data.MySqlClient;

namespace Project_App.GUI.Product_GUI
{
    public partial class Form_ProductDetail : Form
    {
        private int _MaSP;
        private string imagePath;

        public Form_ProductDetail(int MaSP)
        {
            InitializeComponent();
            _MaSP = MaSP;

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel_Image_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ProductDetail_Load(object sender, EventArgs e)
        {
            // Ẩn nút create khi chưa có ảnh
            btn_create.Enabled = false;

            var productDao = new Product_DAO();
            var productSetvice = new Product_Services(productDao);

            Product pro = productSetvice.GetProductById(_MaSP);

            // đưa dữ liệu lên form
            textBox_Name.Text = pro.TenSP.ToString();
            textBox_Price.Text = (string)pro.Gia.ToString();
            textBox_Sale.Text = (string)pro.PhanTramGiamGia.ToString();
            textbox_Title.Text = pro.MoTa.ToString();

            // Thiết lập ComboBox_Category
            ComboBox_Category.Items.Clear();

            // Nếu danh mục của sản phẩm được lấy từ Product, bạn có thể làm như sau:
            var categoryService = new Category_Services(new Category_DAO());
            var categories = categoryService.getAllCategory(); // Lấy tất cả các danh mục

            // Đưa danh sách các danh mục vào ComboBox_Category
            foreach (var category in categories)
            {
                ComboBox_Category.Items.Add(category.TenDanhMuc);
            }

            // Chọn danh mục hiện tại của sản phẩm
            ComboBox_Category.SelectedItem = categories.FirstOrDefault(c => c.MaDanhMuc == pro.MaDanhMuc)?.TenDanhMuc;
            ShowImageProduct();

        }

        private void ShowImageProduct()
        {

            // Xóa các control cũ
            Panel_Image.Controls.Clear();

            ImageProduct_Services imageService = new ImageProduct_Services( new ImageProduct_DAO());
            List<ImageProduct> ListImage = imageService.GetImageByMaSP(_MaSP);

            //đưa hình ảnh vào panle
            int xOffset = 0; // Vị trí hiện tại theo chiều ngang
            int yOffset = 0; // Vị trí hiện tại theo chiều dọc
            int itemWidth = 111; // Chiều rộng UC
            int itemHeight = 133;// Chiều cao UC
            int spacing = 2; // khoảng cách 


            Panel_Image.AutoScroll = true;

            foreach (var img in ListImage)
            {
                Uc_Image imageItem = new Uc_Image()
                {
                    MaHinhAnh = img.MaHinhAnh,
                    UrlImage = img.Url_Img
                };

                // Lắng nghe sự kiện xóa ảnh
                imageItem.ImageDeleted += ShowImageProduct;

                if (xOffset + itemWidth > Panel_Image.Width)
                {
                    xOffset = 0; // Reset vị trí ngang
                    yOffset += itemHeight + spacing; // Di chuyển xuống hàng mới
                }

                // Đặt vị trí cho UserControl
                imageItem.Location = new System.Drawing.Point(xOffset, yOffset);

                // Cập nhật giá trị xOffset để đặt vị trí cho UserControl kế tiếp
                xOffset += itemWidth + spacing;

                // Thêm UserControl vào panel_Products
                Panel_Image.Controls.Add(imageItem);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            textBox_Name.Enabled = true;
            textBox_Price.Enabled = true;
            textbox_Title.Enabled = true;
            textBox_Sale.Enabled = true;
            ComboBox_Category.Enabled = true;

            btn_save.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            textBox_Name.Enabled = false;
            textBox_Price.Enabled = false;
            textbox_Title.Enabled = false;
            textBox_Sale.Enabled = false;
            ComboBox_Category.Enabled = false;

            btn_save.Enabled = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(imagePath))
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            // Configure Cloudinary
            Account account = new Account(
                "dkcizqsb3", // Cloud name
                "949665292283997", // API Key
                "YiDW4WfWgWa9GiY_gtpp95DQwvo" // API Secret
            );
            Cloudinary cloudinary = new Cloudinary(account);

            // Upload the image to Cloudinary
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(imagePath)
            };
            var uploadResult = cloudinary.Upload(uploadParams);

            if (uploadResult.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string imageUrl = uploadResult.SecureUrl.ToString();

                var imageDAO = new ImageProduct_DAO();
                ImageProduct product = new ImageProduct
                {
                    MaSP = _MaSP,
                    Url_Img = imageUrl,
                };
                imageDAO.AddImageProduct(product);

                imagePath = null;
                btn_create.Visible = false;

                MessageBox.Show("Image uploaded successfully and URL saved to the database.");
                ShowImageProduct();
            }
            else
            {
                MessageBox.Show("Failed to upload image to Cloudinary.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load the selected image into the PictureBox
                    pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
                    imagePath = openFileDialog.FileName;

                    // Hiển thị nút 'Create' khi có hình ảnh được chọn
                    btn_create.Enabled = true;
                }
                else
                {
                    btn_create.Enabled = false;
                }
            }
        }
    }
}
