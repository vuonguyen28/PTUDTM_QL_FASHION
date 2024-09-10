using Project_App.DataAccess;
using Project_App.GUI.Product_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlLibrary
{
    public partial class Uc_Image : UserControl
    {
        private string urlImage;
        private int maHinhAnh;

        // Delegate để thông báo sự kiện xóa hình ảnh
        public delegate void ImageDeletedHandler();
        public event ImageDeletedHandler ImageDeleted;

        public string UrlImage { get => urlImage; set => urlImage = value; }
        public int MaHinhAnh { get => maHinhAnh; set => maHinhAnh = value; }

        public Uc_Image()
        {
            InitializeComponent();
        }


        private void Uc_Image_Load(object sender, EventArgs e)
        {
            pictureBox_image.Load(UrlImage);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            var imageProductDAO = new ImageProduct_DAO();
            var result = MessageBox.Show("Are you sure you want to delete this image?", "Delete Image", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                imageProductDAO.DeleteImageProduct(MaHinhAnh);

                // Gọi sự kiện ImageDeleted để form chính tải lại hình ảnh
                ImageDeleted?.Invoke();

                // Hiển thị thông báo khi xóa thành công
                MessageBox.Show("Image deleted successfully.");
            }

        }
    }
}
